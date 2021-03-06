#pragma warning disable 1591
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevExpress.Data.PivotGrid;
    using DevExpress.Utils;
    using DevExpress.Web;
    using DevExpress.Web.ASPxHtmlEditor;
    using DevExpress.Web.ASPxPivotGrid;
    using DevExpress.Web.ASPxRichEdit;
    using DevExpress.Web.ASPxScheduler;
    using DevExpress.Web.ASPxSpellChecker;
    using DevExpress.Web.ASPxSpreadsheet;
    using DevExpress.Web.ASPxThemes;
    using DevExpress.Web.Mvc;
    using DevExpress.Web.Mvc.UI;
    using DevExpress.XtraCharts;
    using DevExpress.XtraCharts.Web;
    using DevExpress.XtraPivotGrid;
    using DevExpress.XtraReports;
    using DevExpress.XtraReports.UI;
    using DevExpress.XtraReports.Web;
    using DevExpress.XtraReports.Web.DocumentViewer;
    using DevExpress.XtraRichEdit;
    using DevExpress.XtraScheduler;
    using DevExpress.XtraScheduler.Native;
    using PolicyTracker.BusinessServices;
    using PolicyTracker.BusinessServices.Security;
    using PolicyTracker.HtmlHelpers;
    using PolicyTracker.Utilities;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Reporting/EmailedReports/MonthlyExpiringAccounts.cshtml")]
    public partial class _Views_Reporting_EmailedReports_MonthlyExpiringAccounts_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Reporting_EmailedReports_MonthlyExpiringAccounts_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
   
    Layout = "~/Views/Shared/_EmailLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>MonthlyExpiringAccounts</h2>\r\n\r\n<p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">Summary</p>\r\n\r\n<table");

WriteLiteral(" class=\"table table-bordered\"");

WriteLiteral(">\r\n    <tbody>\r\n        <tr>\r\n            <td");

WriteLiteral(" style=\"width:250px\"");

WriteLiteral(">Issued</td>\r\n            <td>");

            
            #line 13 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
           Write(ViewBag.Summary.Issued.ToString("C0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Installment/Reporter Deposits" +
"</td>\r\n            <td>");

            
            #line 17 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
           Write(ViewBag.Summary.InstallmentReporterDeposits.ToString("C0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Pending</td>\r\n            <td" +
">");

            
            #line 21 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
           Write(ViewBag.Summary.Pending.ToString("C0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Pending Installment/Reporter " +
"Deposits</td>\r\n            <td>");

            
            #line 25 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
           Write(ViewBag.Summary.PendingDeposits.ToString("C0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n<p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(">Report Details</p>\r\n\r\n<table");

WriteLiteral(" class=\"table table-bordered\"");

WriteLiteral(">\r\n    <tbody>\r\n        <tr");

WriteLiteral(" style=\"border-bottom:1px solid black\"");

WriteLiteral(">\r\n            <td>Effective Date</td>\r\n            <td>Policy #</td>\r\n          " +
"  <td>Underwriter</td>\r\n            <td>Named Insured</td>\r\n            <td>Annu" +
"alized Premium</td>\r\n        </tr>\r\n");

            
            #line 41 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
         foreach(var risk in ViewBag.Risks)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" style=\"width:150px\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
                                   Write(risk.EffectiveDate.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" style=\"width:175px\"");

WriteLiteral(">");

            
            #line 45 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
                                   Write(risk.PolicyNumber);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(">");

            
            #line 46 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
                                   Write(risk.UW);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" style=\"width:300px\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
                                   Write(risk.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 48 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
               Write(risk.AnnualizedPremium.ToString("C0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");

            
            #line 50 "..\..\Views\Reporting\EmailedReports\MonthlyExpiringAccounts.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
