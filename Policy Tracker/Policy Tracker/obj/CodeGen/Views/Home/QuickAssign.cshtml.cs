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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/QuickAssign.cshtml")]
    public partial class _Views_Home_QuickAssign_cshtml : System.Web.Mvc.WebViewPage<PolicyTracker.DTO.UnderwriterQuickAssign>
    {
        public _Views_Home_QuickAssign_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    $(document).ready(function () {
        $(""#QuickAssignForm"").submit(function (event) {
            event.preventDefault();
            ora.Ajax.FormPost(
            {
                url: ""/PolicyTracker/Home/QuickAssign"",
                container: ""QuickAssign_dg"",
                grid: """",
                form: ""QuickAssignForm"",
                data: $(""#QuickAssignForm"").serializeArray(),
                PreventDefault: true,
                dialog: ""QuickAssign_dg"",
                successCallback: function () {
                    $(""#WLRefresh"").click();
                }
            })
        });
    });
</script>

<form");

WriteLiteral(" id=\"QuickAssignForm\"");

WriteLiteral(" class=\"oraForm\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 26 "..\..\Views\Home\QuickAssign.cshtml"
   Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

WriteLiteral("    ");

            
            #line 29 "..\..\Views\Home\QuickAssign.cshtml"
Write(Html.HiddenFor(m => Model.Id));

            
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

WriteLiteral(">\r\n                        <label>Underwriter:</label>\r\n");

WriteLiteral("                        ");

            
            #line 37 "..\..\Views\Home\QuickAssign.cshtml"
                   Write(Html.DropDownListFor(m => Model.UnderwriterId, new SelectList(ViewBag.Underwriters, "UserId", "Name"), "", new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label>Underwriter Assistant:</label>\r\n");

WriteLiteral("                        ");

            
            #line 42 "..\..\Views\Home\QuickAssign.cshtml"
                   Write(Html.DropDownListFor(m => Model.UnderwriterAssistantId, new SelectList(ViewBag.Assistants, "UserId", "Name"), "", new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
" </div>\r\n    </div>\r\n</form>");

        }
    }
}
#pragma warning restore 1591
