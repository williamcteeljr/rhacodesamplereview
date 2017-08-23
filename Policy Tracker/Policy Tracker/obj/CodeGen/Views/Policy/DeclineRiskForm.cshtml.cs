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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Policy/DeclineRiskForm.cshtml")]
    public partial class _Views_Policy_DeclineRiskForm_cshtml : System.Web.Mvc.WebViewPage<PolicyTracker.DomainModel.Policy.Risk>
    {
        public _Views_Policy_DeclineRiskForm_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    ora.Dialog.OverflowVisible(\'RiskDecline_dg\');\r\n</script>\r\n\r\n<form");

WriteLiteral(" id=\"DeclineRiskForm\"");

WriteLiteral(" class=\"oraForm form-horizontal\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 9 "..\..\Views\Policy\DeclineRiskForm.cshtml"
   Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Views\Policy\DeclineRiskForm.cshtml"
Write(Html.HiddenFor(m => Model.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..\Views\Policy\DeclineRiskForm.cshtml"
Write(Html.HiddenFor(m => Model.Prefix));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-8\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel panel-primary borderless\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-info fa-lg\"");

WriteLiteral("></i> Risk Info.\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"panel-body gray\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group thin\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral(">IR #:</label>\r\n                        <div");

WriteLiteral(" class=\"col-sm-9\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"form-control-static\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Policy\DeclineRiskForm.cshtml"
                                                      Write(Model.ImageRightId);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n\r\n             " +
"       <div");

WriteLiteral(" class=\"form-group thin\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral(">Status:</label>\r\n                        <div");

WriteLiteral(" class=\"col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 39 "..\..\Views\Policy\DeclineRiskForm.cshtml"
                       Write(Html.HiddenFor(m => Model.Status, new { value = PolicyTracker.DomainModel.Policy.RiskStatus.DECLINED.Value }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <p");

WriteLiteral(" class=\"form-control-static\"");

WriteLiteral(">Declined</p>\r\n                        </div>\r\n                    </div>\r\n      " +
"              \r\n\r\n                    <div");

WriteLiteral(" class=\"form-group thin\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Reason:</label>\r\n                        <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 48 "..\..\Views\Policy\DeclineRiskForm.cshtml"
                       Write(Html.Partial("ReasonComboBox", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" \r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-lg-4\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel panel-red\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel-heading btn-danger\"");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-ban\"");

WriteLiteral(" style=\"font-size:10em\"");

WriteLiteral("></i>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</" +
"form>");

        }
    }
}
#pragma warning restore 1591
