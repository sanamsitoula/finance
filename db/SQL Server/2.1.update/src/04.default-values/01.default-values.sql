﻿UPDATE finance.accounts
SET account_master_id = finance.get_account_master_id_by_account_master_code('ACP')
WHERE account_name = 'Interest Payable';


UPDATE finance.accounts
SET account_master_id = finance.get_account_master_id_by_account_master_code('FII')
WHERE account_name = 'Finance Charge Income';

IF NOT EXISTS(SELECT 0 FROM finance.account_masters WHERE account_master_code='LOP')
BEGIN
    INSERT INTO finance.account_masters(account_master_id, account_master_code, account_master_name, normally_debit, parent_account_master_id)
    SELECT 15009, 'LOP', 'Loan Payables', 0, 1;

	UPDATE finance.accounts
	SET account_master_id = 15009
	WHERE account_name IN('Loan Payable', 'Bank Loans Payable');
END;

IF NOT EXISTS(SELECT 0 FROM finance.account_masters WHERE account_master_code='LAD') 
BEGIN
    INSERT INTO finance.account_masters(account_master_id, account_master_code, account_master_name, normally_debit, parent_account_master_id)
    SELECT 10104, 'LAD', 'Loan & Advances', 1, 1;

	UPDATE finance.accounts
	SET account_master_id = 10104
	WHERE account_name = 'Loan & Advances';
END;
