﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    
    using Frapid.WebsiteBuilder;
    using MixERP.Finance;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/JournalVerification/Index.cshtml")]
    public partial class _Views_Tasks_JournalVerification_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_JournalVerification_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\JournalVerification\Index.cshtml"
  
    ViewBag.Title = "Journal Verification";
    Layout = ViewBag.FinanceLayoutPath;

            
            #line default
            #line hidden
WriteLiteral("\r\n<style>\r\n    .modal iframe {\r\n        width: 100%;\r\n        border: none;\r\n    " +
"    height: 700px;\r\n    }\r\n</style>\r\n<div");

WriteLiteral(" class=\"ui attached page segment\"");

WriteLiteral(" style=\"min-height: 100%; padding: 3em;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Journal Verification</div>\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"ui basic buttons\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" id=\"AddNewButton\"");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" style=\"\"");

WriteLiteral(" href=\"/dashboard/finance/tasks/journal/entry/new\"");

WriteLiteral(">\r\n            Add New\r\n        </a>\r\n        <a");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" id=\"VerificationApproveButton\"");

WriteLiteral(">Approve</a>\r\n        <a");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" id=\"VerificationRejectButton\"");

WriteLiteral(">Reject</a>\r\n\r\n        <div");

WriteLiteral(" class=\"ui icon top left pointing dropdown basic button\"");

WriteLiteral(" id=\"ExportDropDown\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(">\r\n            <span>\r\n                Export\r\n            </span>\r\n            <" +
"div");

WriteLiteral(" class=\"menu\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n                    Export This Document\r\n                </div>\r\n            " +
"    <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createDoc();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file word outline blue icon\"");

WriteLiteral("></i> Export to Doc\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createXls();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file excel outline green icon\"");

WriteLiteral("></i> Export to Excel\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"item\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"createPDF();\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"file pdf outline red icon\"");

WriteLiteral("></i> Export to PDF\r\n                </a>\r\n            </div>\r\n        </div>\r\n  " +
"      <a");

WriteLiteral(" id=\"PrintButton\"");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(" onclick=\"print()\"");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(">\r\n            Print\r\n        </a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"ui stackable form segment\"");

WriteLiteral(" id=\"Annotation\"");

WriteLiteral(" style=\"\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"eight fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" placeholder=\"From\"");

WriteLiteral(" id=\"FromInputDate\"");

WriteLiteral(" title=\"From\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(" value=\"1/1/2000\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" class=\"date\"");

WriteLiteral(" placeholder=\"To\"");

WriteLiteral(" id=\"ToInputDate\"");

WriteLiteral(" title=\"To\"");

WriteLiteral(" type=\"date\"");

WriteLiteral(" value=\"1/1/2050\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"TranId\"");

WriteLiteral(" id=\"TranIdInputText\"");

WriteLiteral(" title=\"TranId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"TranCode\"");

WriteLiteral(" id=\"TranCodeInputText\"");

WriteLiteral(" title=\"TranCode\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Book\"");

WriteLiteral(" id=\"BookInputText\"");

WriteLiteral(" title=\"Book\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"ReferenceNumber\"");

WriteLiteral(" id=\"ReferenceNumberInputText\"");

WriteLiteral(" title=\"ReferenceNumber\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"StatementReference\"");

WriteLiteral(" id=\"StatementReferenceInputText\"");

WriteLiteral(" title=\"StatementReference\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"PostedBy\"");

WriteLiteral(" id=\"PostedByInputText\"");

WriteLiteral(" title=\"PostedBy\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"eight fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Office\"");

WriteLiteral(" id=\"OfficeInputText\"");

WriteLiteral(" title=\"Office\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Status\"");

WriteLiteral(" id=\"StatusInputText\"");

WriteLiteral(" title=\"Status\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" value=\"Unverified\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"VerifiedBy\"");

WriteLiteral(" id=\"VerifiedByInputText\"");

WriteLiteral(" title=\"VerifiedBy\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"Reason\"");

WriteLiteral(" id=\"ReasonInputText\"");

WriteLiteral(" title=\"Reason\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field hidden\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"UserId\"");

WriteLiteral(" id=\"UserIdInputText\"");

WriteLiteral(" title=\"UserId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field hidden\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" placeholder=\"OfficeId\"");

WriteLiteral(" id=\"OfficeIdInputText\"");

WriteLiteral(" title=\"OfficeId\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui green button\"");

WriteLiteral(" id=\"ShowButton\"");

WriteLiteral(">Show</div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n    <table");

WriteLiteral(" id=\"JournalView\"");

WriteLiteral(" class=\"ui table segment\"");

WriteLiteral(@">
        <thead>
            <tr>
                <th>Actions</th>
                <th>Select</th>
                <th>TranId</th>
                <th>TranCode</th>
                <th>Book</th>
                <th>Value Date</th>
                <th>Book Date</th>
                <th>Ref#</th>
                <th>Statement Reference</th>
                <th>Posted By</th>
                <th>Office</th>
                <th>Status</th>
                <th>Verified By</th>
                <th>Verified On</th>
                <th>Reason</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>

<div");

WriteLiteral(" id=\"ActionModal\"");

WriteLiteral(" class=\"ui modal\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui massive red header\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"ui inverted red content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui form\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui blue large dividing header\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"ReasonTextArea\"");

WriteLiteral(">Verification Reason</label>\r\n                <textarea");

WriteLiteral(" id=\"ReasonTextArea\"");

WriteLiteral("></textarea>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui buttons\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"ui red cancel button\"");

WriteLiteral(" value=\"Cancel\"");

WriteLiteral("/>\r\n            <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"VerifyButton\"");

WriteLiteral(" class=\"ui green ok button\"");

WriteLiteral(" value=\"Verify\"");

WriteLiteral(" title=\"CTRL + RETURN\"");

WriteLiteral("/>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"ui large journal advice modal\"");

WriteLiteral(">\r\n    <i");

WriteLiteral(" class=\"close icon\"");

WriteLiteral("></i>\r\n    <iframe></iframe>\r\n</div>\r\n\r\n<script>\r\n    function displayTable(targe" +
"t, model) {\r\n        target.find(\"tbody\").html(\"\");\r\n\r\n        function getCell(" +
"text) {\r\n            var cell = $(\"<td />\");\r\n\r\n            cell.text(text || \"\"" +
");\r\n\r\n            return cell;\r\n        };\r\n\r\n        function getActionCell(tra" +
"nId) {\r\n            var cell = $(\"<td />\");\r\n\r\n            var checklistAnchor =" +
" $(\"<a title=\'Checklist Window\'><i class=\'list icon\'></i></a>\");\r\n            ch" +
"ecklistAnchor.attr(\"href\", \"/dashboard/finance/tasks/journal/checklist/\" + tranI" +
"d);\r\n\r\n            var printAnchor = $(\"<a title=\'View Journal Advice\'><i class=" +
"\'print icon\'></i></a>\");\r\n            printAnchor.attr(\"href\", \"javascript:void(" +
"0);\");\r\n            printAnchor.attr(\"onclick\", \"showJournalAdvice(\" + tranId + " +
"\");\");\r\n\r\n            cell.append(checklistAnchor);\r\n            cell.append(pri" +
"ntAnchor);\r\n            return cell;\r\n        };\r\n\r\n        function getSelectio" +
"nCell() {\r\n            var cell = $(\"<td />\");\r\n            var checkbox = $(\"<d" +
"iv class=\'ui toggle checkbox\'/>\");\r\n            var input = $(\"<input type=\'chec" +
"kbox\' />\");\r\n            var label = $(\"<label />\");\r\n\r\n            checkbox.app" +
"end(input);\r\n            checkbox.append(label);\r\n\r\n            cell.append(chec" +
"kbox);\r\n\r\n            return cell;\r\n        };\r\n\r\n        $.each(model,\r\n       " +
"     function() {\r\n                var item = this;\r\n\r\n                var row =" +
" $(\"<tr />\");\r\n\r\n                row.append(getActionCell(item.TransactionMaster" +
"Id));\r\n                row.append(getSelectionCell());\r\n                row.appe" +
"nd(getCell(item.TransactionMasterId));\r\n                row.append(getCell(item." +
"TransactionCode));\r\n                row.append(getCell(item.Book));\r\n           " +
"     row.append(getCell(item.ValueDate));\r\n                row.append(getCell(it" +
"em.BookDate));\r\n                row.append(getCell(item.ReferenceNumber));\r\n    " +
"            row.append(getCell(item.StatementReference));\r\n                row.a" +
"ppend(getCell(item.PostedBy));\r\n                row.append(getCell(item.Office))" +
";\r\n                row.append(getCell(item.Status));\r\n                row.append" +
"(getCell(item.VerifiedBy));\r\n                row.append(getCell(item.VerifiedOn)" +
");\r\n                row.append(getCell(item.Reason));\r\n\r\n                target." +
"find(\"tbody\").append(row);\r\n            });\r\n    };\r\n\r\n    function processQuery" +
"() {\r\n        function getModel() {\r\n            var model = window.serializeFor" +
"m($(\"#Annotation\"));\r\n            model.Book = \"Journal Entry\";\r\n            ret" +
"urn model;\r\n        };\r\n\r\n        function displayGrid(target) {\r\n            fu" +
"nction request(model) {\r\n                var url = \"/dashboard/finance/tasks/jou" +
"rnal/view\";\r\n                var data = JSON.stringify(model);\r\n                " +
"return window.getAjaxRequest(url, \"POST\", data);\r\n            };\r\n\r\n            " +
"var model = getModel();\r\n\r\n            var ajax = request(model);\r\n\r\n           " +
" ajax.success(function(response) {\r\n                displayTable(target, respons" +
"e);\r\n                target.removeClass(\"loading\");\r\n            });\r\n\r\n        " +
"    ajax.fail(function(xhr) {\r\n                alert(JSON.stringify(xhr));\r\n    " +
"        });\r\n        };\r\n\r\n        var view = $(\"#JournalView\").addClass(\"loadin" +
"g\");\r\n\r\n        displayGrid(view);\r\n    };\r\n\r\n    $(\"#ShowButton\")\r\n        .unb" +
"ind(\"click\")\r\n        .bind(\"click\",\r\n            function() {\r\n                " +
"processQuery();\r\n            });\r\n\r\n    setTimeout(function () {\r\n        proces" +
"sQuery();\r\n    }, 1000);\r\n</script>\r\n\r\n<script>\r\n    var reasonTextArea = $(\"#Re" +
"asonTextArea\");\r\n    var journalView = $(\"#JournalView\");\r\n    var modal = $(\"#A" +
"ctionModal\");\r\n    var verifyButton = $(\"#VerifyButton\");\r\n    var tranId;\r\n    " +
"var approve;\r\n\r\n    function getSelectedItem() {\r\n        var selected = journal" +
"View.find(\"input:checked\").first();\r\n        \r\n        if (selected.length) {\r\n " +
"           var row = selected.parent().parent().parent();\r\n            var id = " +
"row.find(\"td:nth-child(3)\").html();\r\n            return parseInt(id);\r\n        }" +
";\r\n\r\n        return 0;\r\n    };\r\n\r\n    function showModal() {\r\n        var header" +
" = modal.find(\".ui.massive.header\");\r\n        var subheader = modal.find(\".ui.di" +
"viding.header\");\r\n\r\n        header.html(\"Reject Transaction\");\r\n        subheade" +
"r.html(window.stringFormat(\"TranId: #{0}\", tranId));\r\n        header.removeClass" +
"(\"green\").addClass(\"red\");\r\n\r\n        if (approve) {\r\n            header.html(\"A" +
"pprove Transaction\");\r\n            header.removeClass(\"red\").addClass(\"green\");\r" +
"\n        };\r\n\r\n        modal.modal(\'setting\', \'closable\', false).modal(\'show\');\r" +
"\n    };\r\n\r\n    $(\"#VerificationApproveButton\").click(function () {\r\n        tran" +
"Id = getSelectedItem();\r\n\r\n        if (tranId) {\r\n            approve = true;\r\n " +
"           showModal();\r\n        };\r\n    });\r\n\r\n    $(\"#VerificationRejectButton" +
"\").click(function () {\r\n        tranId = getSelectedItem();\r\n\r\n        if (tranI" +
"d) {\r\n            approve = false;\r\n            showModal();\r\n        };\r\n    })" +
";\r\n\r\n    function removeRow(index, callback) {\r\n        journalView.find(\"tr\").e" +
"q(index + 1).addClass(\"negative\").fadeOut(500, function () {\r\n            $(this" +
").remove();\r\n\r\n            if (typeof (callback) === \"function\") {\r\n            " +
"    callback();\r\n            };\r\n        });\r\n    };\r\n\r\n    function hideModal()" +
" {\r\n        modal.modal(\"hide\");\r\n    };\r\n\r\n    verifyButton.click(function () {" +
"\r\n        function getModel() {\r\n            var reason = reasonTextArea.val();\r" +
"\n\r\n            return {\r\n                TranId: tranId,\r\n                Reason" +
": reason\r\n            };\r\n        };\r\n\r\n        function request(model, type) {\r" +
"\n            var url = \"/dashboard/finance/tasks/journal/verification/\" + type;\r" +
"\n            var data = JSON.stringify(model);\r\n\r\n            return window.getA" +
"jaxRequest(url, \"POST\", data);\r\n        }\r\n\r\n        var model = getModel();\r\n  " +
"      var type = approve ? \"approve\" : \"reject\";\r\n\r\n        var ajax = request(m" +
"odel, type);\r\n\r\n        ajax.success(function (response) {\r\n            var casc" +
"adingTranId = parseFloat(response);\r\n\r\n            if (cascadingTranId) {\r\n     " +
"           journalView.find(\"tr td:nth-child(3)\").each(function (i) {\r\n         " +
"           var tranId = parseFloat($(this).text() || 0);\r\n\r\n                    " +
"if (cascadingTranId === tranId) {\r\n                        removeRow(i);\r\n      " +
"              };\r\n                });\r\n            };\r\n\r\n            journalView" +
".find(\"input:checked\").first().parent().parent().parent().remove();\r\n           " +
" hideModal();\r\n        });\r\n\r\n        ajax.fail(function (xhr) {\r\n            wi" +
"ndow.logAjaxErrorMessage(xhr);\r\n        });\r\n\r\n        return false;\r\n    });\r\n\r" +
"\n    $(document).keyup(function (e) {\r\n        if (e.ctrlKey) {\r\n            var" +
" rowNumber = e.keyCode - 47;\r\n\r\n            if (rowNumber < 10) {\r\n             " +
"   journalView.find(\"tr\").eq(rowNumber).find(\"input\").trigger(\'click\');\r\n       " +
"     };\r\n        };\r\n    });\r\n\r\n    shortcut.add(\"CTRL+K\", function () {\r\n      " +
"  $(\"#ApproveButton\").trigger(\"click\");\r\n    });\r\n\r\n    shortcut.add(\"CTRL+RETUR" +
"N\", function () {\r\n        if (modal.is(\":visible\")) {\r\n            verifyButton" +
".trigger(\"click\");\r\n        };\r\n    });\r\n\r\n    shortcut.add(\"CTRL+SHIFT+K\", func" +
"tion () {\r\n        $(\"#VerificationRejectButton\").trigger(\"click\");\r\n    });\r\n\r\n" +
"    function showJournalAdvice(tranId) {\r\n        $(\".journal.advice.modal ifram" +
"e\").attr(\"src\", \"/dashboard/reports/source/Areas/MixERP.Finance/Reports/JournalE" +
"ntry.xml?transaction_master_id=\" + tranId);\r\n\r\n        setTimeout(function () {\r" +
"\n            $(\".journal.advice.modal\")\r\n                .modal(\'setting\', \'tran" +
"sition\', \'horizontal flip\')\r\n                .modal({\r\n                    blurr" +
"ing: true\r\n                })\r\n                .modal(\"show\");\r\n\r\n        }, 300" +
");\r\n    };\r\n</script>");

        }
    }
}
#pragma warning restore 1591
