﻿using System;
using System.Threading.Tasks;
using Frapid.ApplicationState.Models;
using Frapid.Configuration;
using Frapid.Configuration.Db;
using Frapid.DataAccess;
using Frapid.Framework.Extensions;
using Frapid.Mapper;
using Frapid.Mapper.Query.Insert;
using Frapid.Mapper.Query.NonQuery;
using MixERP.Finance.DTO;
using MixERP.Finance.ViewModels;

namespace MixERP.Finance.DAL
{
    public static class TransacitonPostings
    {
        public static async Task<bool> CanPostTransactionAsync(string tenant, long loginId, int userId, int officeId, string transactionBook, DateTime valueDate)
        {
            const string sql = "SELECT finance.can_post_transaction(@0, @1, @2, @3, @4);";
            return await Factory.ScalarAsync<bool>(tenant, sql, loginId, userId, officeId, transactionBook, valueDate).ConfigureAwait(false);
        }

        public static async Task<long> AddAsync(string tenant, LoginView userInfo, TransactionPosting model)
        {
            long transactionMasterId = 0;
            string bookName = "Journal Entry";
            bool canPost = await CanPostTransactionAsync(tenant, userInfo.LoginId, userInfo.UserId, userInfo.OfficeId, bookName, model.ValueDate).ConfigureAwait(false);

            if (!canPost)
            {
                return transactionMasterId;
            }


            using (var db = DbProvider.Get(FrapidDbServer.GetConnectionString(tenant), tenant).GetDatabase())
            {
                try
                {
                    await db.BeginTransactionAsync().ConfigureAwait(false);

                    var master = new TransactionMaster
                    {
                        Book = bookName,
                        ValueDate = model.ValueDate,
                        BookDate = model.BookDate,
                        TransactionTs = DateTimeOffset.UtcNow,
                        TransactionCode = string.Empty,
                        LoginId = userInfo.LoginId,
                        UserId = userInfo.UserId,
                        OfficeId = userInfo.OfficeId,
                        CostCenterId = model.CostCenterId,
                        ReferenceNumber = model.ReferenceNumber,
                        StatementReference = string.Empty,
                        VerificationStatusId = 0,
                        VerificationReason = string.Empty,
                        AuditUserId = userInfo.UserId,
                        AuditTs = DateTimeOffset.UtcNow,
                        Deleted = false
                    };

                    var insertedId =
                        await
                            db.InsertAsync("finance.transaction_master", "transaction_master_id", true, master)
                                .ConfigureAwait(true);

                    transactionMasterId = insertedId.To<long>();


                    foreach (var line in model.Details)
                    {
                        decimal amountInCurrency;
                        string tranType;
                        decimal amountInLocalCurrency;

                        if (line.Credit.Equals(0) && line.Debit > 0)
                        {
                            tranType = "Dr";
                            amountInCurrency = line.Debit;
                            amountInLocalCurrency = line.LocalCurrencyDebit;
                        }
                        else
                        {
                            tranType = "Cr";
                            amountInCurrency = line.Credit;
                            amountInLocalCurrency = line.LocalCurrencyCredit;
                        }


                        var detail = new TransactionDetail
                        {
                            TransactionMasterId = transactionMasterId,
                            ValueDate = model.ValueDate,
                            BookDate = model.BookDate,
                            TranType = tranType,
                            AccountId = await Accounts.GetAccountIdByAccountNumberAsync(tenant, line.AccountNumber).ConfigureAwait(false),
                            StatementReference = line.StatementReference,
                            CashRepositoryId = await CashRepositories.GetCashRepositoryIdByCashRepositoryCodeAsync(tenant, line.CashRepositoryCode).ConfigureAwait(false),
                            CurrencyCode = line.CurrencyCode,
                            AmountInCurrency = amountInCurrency,
                            OfficeId = userInfo.OfficeId,
                            LocalCurrencyCode = userInfo.CurrencyCode,
                            Er = line.ExchangeRate,
                            AmountInLocalCurrency = amountInLocalCurrency,
                            AuditUserId = userInfo.UserId,
                            AuditTs = DateTimeOffset.UtcNow
                        };

                        await db.InsertAsync("finance.transaction_details", "transaction_detail_id", true, detail).ConfigureAwait(false);
                    }

                    if (model.Attachemnts != null && model.Attachemnts.Count > 0)
                    {
                        foreach (var item in model.Attachemnts)
                        {
                            var document = new TransactionDocument
                            {
                                TransactionMasterId = transactionMasterId,
                                OriginalFileName = item.OriginalFileName,
                                FileExtension = item.FileExtension,
                                FilePath = item.FilePath,
                                Memo = item.Memo,
                                AuditUserId = userInfo.UserId,
                                AuditTs = DateTimeOffset.UtcNow,
                                Deleted = false
                            };

                            await db.InsertAsync("finance.transaction_documents", "document_id", true, document).ConfigureAwait(false);
                        }
                    }

                    var sql = new Sql("SELECT * FROM finance.auto_verify(@0::bigint, @1::integer)", transactionMasterId, userInfo.UserId);
                    await db.NonQueryAsync(sql).ConfigureAwait(false);

                    db.CommitTransaction();
                }
                catch (Exception)
                {
                    db.RollbackTransaction();
                    throw;
                }
            }

            return transactionMasterId;
        }
    }
}