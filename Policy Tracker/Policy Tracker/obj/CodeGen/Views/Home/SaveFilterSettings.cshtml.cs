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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/SaveFilterSettings.cshtml")]
    public partial class _Views_Home_SaveFilterSettings_cshtml : System.Web.Mvc.WebViewPage<PolicyTracker.DomainModel.Common.UserFilter>
    {
        public _Views_Home_SaveFilterSettings_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/ecmascript\"");

WriteLiteral(">\r\n    $(document).ready(function () {\r\n        $(\"form#UserFilterForm\").find(\"#N" +
"ame\").val($(\"#WLMyFilter option:selected\").text());\r\n    });\r\n</script>\r\n\r\n<form" +
"");

WriteLiteral(" id=\"UserFilterForm\"");

WriteLiteral(" class=\"oraForm\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Home\SaveFilterSettings.cshtml"
   Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Home\SaveFilterSettings.cshtml"
Write(Html.HiddenFor(m => Model.UserId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Views\Home\SaveFilterSettings.cshtml"
Write(Html.HiddenFor(m => Model.Expression));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-12\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel panel-primary borderless\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel-body gray\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label>Name</label>\r\n                        <i");

WriteLiteral(" class=\"btn btn-danger reqField RFD hidden\"");

WriteLiteral(" data-dec-field=\"PolicyType\"");

WriteLiteral(">D</i>\r\n");

WriteLiteral("                        ");

            
            #line 24 "..\..\Views\Home\SaveFilterSettings.cshtml"
                   Write(Html.TextBoxFor(m => Model.Name, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\n                    \r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label>For Month</label>\r\n                        <sel" +
"ect");

WriteLiteral(" id=\"MonthFilter\"");

WriteLiteral(" name=\"MonthFilter\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n                            <option");

WriteLiteral(" value=\"0\"");

WriteLiteral("></option>\r\n                            <option");

WriteLiteral(" value=\"1\"");

WriteLiteral(">Current</option>\r\n                            <option");

WriteLiteral(" value=\"2\"");

WriteLiteral(">Next</option>\r\n                            <option");

WriteLiteral(" value=\"3\"");

WriteLiteral(">Month After Next</option>\r\n                        </select>\r\n                  " +
"      <p");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">If selected updates the filter to also filter by the risk effective date in the " +
"desired month. \r\n                            (Ex. Next Month would mean risks wi" +
"th effective date in ");

            
            #line 36 "..\..\Views\Home\SaveFilterSettings.cshtml"
                                                                               Write(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.AddMonths(1).Month));

            
            #line default
            #line hidden
WriteLiteral(")\r\n\r\n                        </p>\r\n                    </div>\r\n\r\n                " +
"    ");

WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 51 "..\..\Views\Home\SaveFilterSettings.cshtml"
               Write(Html.Label("Filter:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" style=\"clear:both;float:left\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Home\SaveFilterSettings.cshtml"
                                                   Write(Model.Expression);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n" +
"</form>");

        }
    }
}
#pragma warning restore 1591
