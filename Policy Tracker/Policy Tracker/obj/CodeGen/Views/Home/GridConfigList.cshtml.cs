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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/GridConfigList.cshtml")]
    public partial class _Views_Home_GridConfigList_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_GridConfigList_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"dropdown gridMenu\"");

WriteLiteral(">\r\n    <button");

WriteLiteral(" class=\"btn btn-primary dropdown-toggle\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"testtest\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span>\r\n    </button>\r\n    <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(" >\r\n");

            
            #line 6 "..\..\Views\Home\GridConfigList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Home\GridConfigList.cshtml"
         foreach(var config in ViewBag.GridConfigs)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteLiteral(" href=\"#\"");

WriteAttribute("ora-grid-config", Tuple.Create(" ora-grid-config=\"", 357), Tuple.Create("\"", 387)
            
            #line 8 "..\..\Views\Home\GridConfigList.cshtml"
, Tuple.Create(Tuple.Create("", 375), Tuple.Create<System.Object, System.Int32>(config.Name
            
            #line default
            #line hidden
, 375), false)
);

WriteLiteral(" class=\"gridConfigLink\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Home\GridConfigList.cshtml"
                                                                             Write(config.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 9 "..\..\Views\Home\GridConfigList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    $("".gridConfigLink"").each(function () {
        $(this).click(function (e) {
            e.preventDefault();
            var config = $(this).attr('ora-grid-config');
            ora.Ajax.Ajax({
                url: '/policytracker/home/WorkingList?gridConfig=' + config, type: 'GET', dataType: 'HTML',
                successCallback: function (html) {
                    $(""#page-wrapper"").html(html);
                    var commandMenuHeight = $('#WorkingListCommandMenu').height();
                    var height = $('#page-wrapper').height();
                    WorkingListGrid.SetHeight(height - 93 - (commandMenuHeight - 34));
                    var containerWidth = $('#page-wrapper').width();
                    WorkingListGrid.SetWidth(containerWidth);
                }
            });
        });
    });
</script>");

        }
    }
}
#pragma warning restore 1591
