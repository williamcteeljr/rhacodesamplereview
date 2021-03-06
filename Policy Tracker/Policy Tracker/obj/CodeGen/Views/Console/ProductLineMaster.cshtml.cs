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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Console/ProductLineMaster.cshtml")]
    public partial class _Views_Console_ProductLineMaster_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Console_ProductLineMaster_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Console\ProductLineMaster.cshtml"
  
    ViewBag.Title = "Product Line Detail";
    Layout = "~/Views/Shared/_DevExtremeLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 6 "..\..\Views\Console\ProductLineMaster.cshtml"
Write(Scripts.Render("~/angular/filters"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Console\ProductLineMaster.cshtml"
Write(Scripts.Render("~/angular/factories"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Console\ProductLineMaster.cshtml"
Write(Scripts.Render("~/angular/controllers"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..\Views\Console\ProductLineMaster.cshtml"
Write(Scripts.Render("~/plugins/ui-bootstrap"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\Console\ProductLineMaster.cshtml"
Write(Scripts.Render("~/plugins/fcsaNumber"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(document).ready(function () { $(\'#openConsoleSettings\').click(function (" +
") { $(\'#consoleSettingsModal\').modal(\'show\') }) })\r\n</script>\r\n\r\n<style>\r\n    .b" +
"tn-app-mod {\r\n        padding: 12px 16px !important;\r\n        margin: initial !i" +
"mportant;\r\n        min-width: initial !important;\r\n        height: inherit !impo" +
"rtant;\r\n    }\r\n\r\n    .dx-dropdowneditor-icon {\r\n        background-image: none;\r" +
"\n        width: 100%;\r\n    }\r\n\r\n    .dx-datagrid .dx-column-lines > td {\r\n      " +
"  border-right: 1px solid #0a0a0a;\r\n    }\r\n\r\n    .tableBorder {\r\n        border:" +
" 1px solid black !important;\r\n        border-left: 2px solid black !important;\r\n" +
"        border-right: 2px solid black !important;\r\n    }\r\n\r\n    .forecasting {\r\n" +
"        background-color: white;\r\n    }\r\n\r\n    .consoleToolbar {\r\n        positi" +
"on: absolute;\r\n        left: 0px;\r\n        right: 0px;\r\n    }\r\n\r\n    .console {\r" +
"\n        position: absolute;\r\n        top: 60px;\r\n        bottom: 0px;\r\n        " +
"overflow: auto;\r\n        right: 0px;\r\n        left: 0px;\r\n    }\r\n\r\n    .dx-tabs-" +
"nav-button {\r\n        position: absolute !important;\r\n        height: 100% !impo" +
"rtant;\r\n    }\r\n\r\n    .dx-tabs .dx-tabs-nav-button-right {\r\n        margin-top: 0" +
"px !important;\r\n    }\r\n\r\n    .dx-button-has-icon:not(.dx-button-has-text) {\r\n   " +
"     padding: 0px !important;\r\n    }\r\n    /*.dx-tab { padding:0px !important;}*/" +
"\r\n\r\n    .dx-tab-selected {\r\n        background-color: #3c8dbc !important;\r\n     " +
"   opacity: .65;\r\n    }\r\n\r\n        .dx-tab-selected .dx-item-content .dx-tab-tex" +
"t {\r\n            color: white !important;\r\n        }\r\n\r\n    .header {\r\n        f" +
"ont-weight: bold;\r\n        font-size: 16px;\r\n    }\r\n</style>\r\n\r\n<div");

WriteLiteral(" ng-app=\"ProductLineMaster\"");

WriteLiteral(" ng-controller=\"consoleController\"");

WriteLiteral(" ng-cloak>\r\n\r\n    <script");

WriteLiteral(" type=\"text/ng-template\"");

WriteLiteral(" id=\"myModalContent.html\"");

WriteLiteral(@">
        <div class=""modal-header"">
            <h3 class=""modal-title"">Product Line Console Help</h3>
        </div>
        <div class=""modal-body"">
            <p>* When looking at a future year only a full year summary is possible.</p>
        </div>
        <div class=""modal-footer"">
            <button class=""btn btn-primary"" type=""button"" ng-click=""ok()"">OK</button>
        </div>
    </script>

    <!-- #region Console Toolbar -->
    <div");

WriteLiteral(" class=\"consoleToolbar\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-12 fillContainer\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel panel-primary borderless stacked\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel-body bg-navy fillContainer\"");

WriteLiteral(" style=\"color:white;padding:5px 5px!important\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-lg-4 col-md-5 col-sm-6 col-xs-6 noPadding\"");

WriteLiteral(">\r\n                        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(" style=\"margin-bottom:0px;line-height: 45px;\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default dropdown-toggle btn-lg\"");

WriteLiteral(" id=\"openConsoleSettings\"");

WriteLiteral(" title=\"Edit Console Settings\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-wrench\"");

WriteLiteral("></i> &nbsp;&nbsp;{{productLine.Name}} {{month.Name}} {{year}}</button>\r\n        " +
"                    <a");

WriteLiteral(" class=\"btn btn-app btn-app-mod\"");

WriteLiteral(" ng-click=\"reloadPage()\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"fa fa-refresh\"");

WriteLiteral("></i>\r\n                            </a>\r\n                            <a");

WriteLiteral(" class=\"btn btn-app btn-app-mod\"");

WriteLiteral(" ng-show=\"impactNotes.length > 0\"");

WriteLiteral(" ng-click=\"showNotes = !showNotes\"");

WriteLiteral(">\r\n                                <span");

WriteLiteral(" class=\"badge bg-red\"");

WriteLiteral(">{{impactNotes.length}}</span>\r\n                                <i");

WriteLiteral(" class=\"fa fa-bullhorn\"");

WriteLiteral("></i>\r\n                            </a>\r\n                        </p>\r\n          " +
"          </div>\r\n                    <div");

WriteLiteral(" class=\"col-lg-8 col-md-7 col-sm-6 col-xs-6 noPadding\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"scrolledtabs\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" dx-tabs=\"scrolledTabsOptions\"");

WriteLiteral("></div>\r\n                        </div>\r\n                    </div>\r\n            " +
"    </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"modal\"");

WriteLiteral(" id=\"consoleSettingsModal\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(" role=\"document\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n                    <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"exampleModalLabel\"");

WriteLiteral(">Console Settings</h4>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" style=\"float:none;font-size:15px\"");

WriteLiteral(">Product Line</label>\r\n                        <select");

WriteLiteral(" ng-model=\"consoleSettings.productLine\"");

WriteLiteral(" ng-options=\"pl as pl.Name for pl in ProductLines track by pl.ProductLineId\"");

WriteLiteral(" ng-change=\"resetForecast = true\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></select>\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" style=\"float:none;font-size:15px\"");

WriteLiteral(">Underwriter</label>\r\n                        <select");

WriteLiteral(" ng-model=\"consoleSettings.underwriter\"");

WriteLiteral(" ng-options=\"uw as uw.Name for uw in Underwriters track by uw.UserId\"");

WriteLiteral(" ng-change=\"resetForecast = true\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></select>\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" style=\"float:none;font-size:15px\"");

WriteLiteral(">Year</label>\r\n                        <select");

WriteLiteral(" ng-model=\"consoleSettings.year\"");

WriteLiteral(" ng-options=\"y for y in Years\"");

WriteLiteral(" ng-change=\"resetForecast = true\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></select>\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" style=\"float:none;font-size:15px\"");

WriteLiteral(">Branch</label>\r\n                        <select");

WriteLiteral(" ng-model=\"consoleSettings.branch\"");

WriteLiteral(" ng-options=\"b as b.displayText for b in branches track by b.branch\"");

WriteLiteral(" ng-change=\"resetForecast = true\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></select>\r\n                    </div>\r\n                </div>\r\n\r\n               " +
" <div");

WriteLiteral(" class=\"modal-footer\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" ng-click=\"updateConsoleSettings()\"");

WriteLiteral(">Update Console</button>\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(">Cancel</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n   " +
" </div>\r\n\r\n    <!-- #endregion -->\r\n    <div");

WriteLiteral(" class=\"console\"");

WriteLiteral(" ng-show=\"viewing == views[0]\"");

WriteLiteral(">\r\n        <section");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"error-page\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"text-yellow\"");

WriteLiteral(" style=\"font-size:40px; font-weight:300\"");

WriteLiteral(">Loading Product Line Summary...</h1>\r\n            </div>\r\n        </section>\r\n  " +
"  </div>\r\n\r\n    <div");

WriteLiteral(" class=\"console\"");

WriteLiteral(" ng-show=\"viewing == views[1]\"");

WriteLiteral(">\r\n        <section");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"error-page\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"text-red\"");

WriteLiteral(" style=\"font-size:40px; font-weight:300\"");

WriteLiteral(">01000010 01110010 01101111</h2>\r\n                <div");

WriteLiteral(" class=\"error-content\"");

WriteLiteral(" style=\"margin-left:0px\"");

WriteLiteral(">\r\n                    <h3><i");

WriteLiteral(" class=\"fa fa-warning text-red\"");

WriteLiteral(@"></i> Oops! Something went wrong.</h3>
                    <p>
                        Refresh the page or select a different month to try again...
                    </p>
                </div>
            </div><!-- /.error-page -->
        </section>
    </div>



    <div");

WriteLiteral(" class=\"row console\"");

WriteLiteral(" style=\"margin-right:0px!important\"");

WriteLiteral(" ng-show=\"viewing == views[2]\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-12\"");

WriteLiteral(" ng-show=\"showNotes\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"box box-solid\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"box-header with-border text-red\"");

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">Important Notes</h3>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"box-body\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"post\"");

WriteLiteral(" ng-repeat=\"note in impactNotes\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"user-block\"");

WriteLiteral(">\r\n                            <h4");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i></h4>\r\n                            <span");

WriteLiteral(" class=\"username\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">{{note.Name}} (Created By)</a>\r\n                            </span>\r\n           " +
"                 <span");

WriteLiteral(" class=\"description\"");

WriteLiteral(@">{{note.ImpactDate | date:""shortDate""}} (Impact Date)</span>
                        </div><!-- /.user-block -->
                        <p>
                            {{note.Comment}}
                        </p>
                    </div>
                </div>
            </div>
        </div>
        <!-- #region New Business/Renewal Chart & Month Summary -->
        <div");

WriteLiteral(" class=\"consoleSummaries\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-lg-4 col-md-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"box box-solid\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box-header with-border\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">{{month.Name}} Renewals & New Business Summary</h3>\r\n                    </div><" +
"!-- /.box-header -->\r\n                    <div");

WriteLiteral(" class=\"box-body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(" style=\"font-size:16px\"");

WriteLiteral(">\r\n                            <table");

WriteLiteral(" class=\"table table-hover\"");

WriteLiteral(">\r\n                                <thead>\r\n                                    <" +
"tr>\r\n                                        <th></th>\r\n                        " +
"                <th");

WriteLiteral(" class=\"success\"");

WriteLiteral(">Renewals</th>\r\n                                        <th");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">New Business</th>\r\n                                    </tr>\r\n                  " +
"              </thead>\r\n                                <tbody>\r\n               " +
"                     <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Renewals/Submissions</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.RETotal}}</td>\r\n                                        <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBTotal}}</td>\r\n                                    </tr>\r\n              " +
"                      <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Policy Count Bound</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REBoundTotal}}</td>\r\n                                        <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBBoundTotal}}</td>\r\n                                    </tr>\r\n         " +
"                           <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Total Booked Premium</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.RETotalBookedPremium | currency:\"$\":0}}</td>\r\n                           " +
"             <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBTotalBookedPremium | currency:\"$\":0}}</td>\r\n                           " +
"         </tr>\r\n                                    <tr>\r\n                      " +
"                  <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Total Written Premium</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.RETotalWrittenPremium | currency:\"$\":0}}</td>\r\n                          " +
"              <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBTotalWrittenPremium | currency:\"$\":0}}</td>\r\n                          " +
"          </tr>\r\n                                    <tr>\r\n                     " +
"                   <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Non-renewed/Unsuccesful Policy Count</td>\r\n                                     " +
"   <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.RETotalUnsuccessful}}</td>\r\n                                        <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBTotalUnsuccessful}}</td>\r\n                                    </tr>\r\n  " +
"                                  <tr>\r\n                                        " +
"<td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Non-renewed/Unsuccesful Premium</td>\r\n                                        <t" +
"d");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.RETotalUnsuccessfulPremium | currency:\"$\":0}}</td>\r\n                     " +
"                   <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBTotalUnsuccessfulPremium | currency:\"$\":0}}</td>\r\n                     " +
"               </tr>\r\n                                    <tr>\r\n                " +
"                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Quoted Policy Count</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REQuotedTotal}}</td>\r\n                                        <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBQuotedTotal}}</td>\r\n                                    </tr>\r\n        " +
"                            <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Outstanding Quoted & Un-Quoted Premium</td>\r\n                                   " +
"     <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REOutstandingPremium | currency:\"$\":0}}</td>\r\n                           " +
"             <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBOutstandingPremium | currency:\"$\":0}}</td>\r\n                           " +
"         </tr>\r\n                                    <tr>\r\n                      " +
"                  <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Declined Policy Count</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REDeclinedTotal}}</td>\r\n                                        <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBDeclinedTotal}}</td>\r\n                                    </tr>\r\n      " +
"                              <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Declined Premium</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REDeclinedPremium | currency:\"$\":0}}</td>\r\n                              " +
"          <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBDeclinedPremium | currency:\"$\":0}}</td>\r\n                              " +
"      </tr>\r\n                                    <tr>\r\n                         " +
"               <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Expiring Booked Premium</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REExpiringBookedPremium | currency:\"$\":0}}</td>\r\n                        " +
"                <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral("></td>\r\n                                    </tr>\r\n                              " +
"      <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Expiring Written Premium</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REExpiringWrittenPremium | currency:\"$\":0}}</td>\r\n                       " +
"                 <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral("></td>\r\n                                    </tr>\r\n                              " +
"      <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Expiring Premium lost</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REExpiringPremiumLost | currency:\"$\":0}}</td>\r\n                          " +
"              <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral("></td>\r\n                                    </tr>\r\n                              " +
"      <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Policy Retention Ratio</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REPolicyRetentionRatio | number : 2}} %</td>\r\n                           " +
"             <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral("></td>\r\n                                    </tr>\r\n                              " +
"      <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Premium Retention Ratio</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.REPremiumRetentionRatio}} %</td>\r\n                                       " +
" <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral("></td>\r\n                                    </tr>\r\n                              " +
"      <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Hit Ratio Count</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral("></td>\r\n                                        <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBHitRatio}} %</td>\r\n                                    </tr>\r\n         " +
"                           <tr>\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Hit Ratio Premium</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral("></td>\r\n                                        <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">{{data.NBHitRatioPremium}} %</td>\r\n                                    </tr>\r\n  " +
"                                  <tr>\r\n                                        " +
"<td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">N/R Change</td>\r\n                                        <td");

WriteLiteral(" class=\"success\"");

WriteLiteral(">{{data.RenewalNetRateChange | number : 4}} %</td>\r\n                             " +
"           <td");

WriteLiteral(" class=\"primary\"");

WriteLiteral(@"></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div><!-- /.box-body -->
                </div>
            </div>

            <div");

WriteLiteral(" class=\"col-lg-8 col-md-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"box box-solid\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box-header with-border\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">{{month.Name}} Summary</h3>\r\n                    </div><!-- /.box-header -->\r\n  " +
"                  <div");

WriteLiteral(" class=\"box-body\"");

WriteLiteral(">\r\n                        <table");

WriteLiteral(" class=\"table table-hover\"");

WriteLiteral(" style=\"font-size:16px\"");

WriteLiteral(">\r\n                            <tbody>\r\n                                <tr>\r\n   " +
"                                 <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(@"><strong>Total Booked Production (Not including Installments)</strong></td>
                                    <td>{{data.TotalBooked | currency:""$"":0}}</td>
                                </tr>
                                <tr>
                                    <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Installments</td>\r\n                                    <td>{{data.TotalInstallme" +
"nts | currency:\"$\":0}} <span");

WriteLiteral(" title=\"Prior Years Installment Amount\"");

WriteLiteral(" ng-show=\"data.PriorInstallments != 0\"");

WriteLiteral(">/ {{data.PriorInstallments | currency:\"$\":0}}</span></td>\r\n                     " +
"               <td");

WriteLiteral(" class=\"primary tableBorder\"");

WriteLiteral(" style=\"border-top:2px solid black;max-width:200px\"");

WriteLiteral("><p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(" style=\"margin-bottom:0px\"");

WriteLiteral("><strong>Forecasting</strong></p></td>\r\n                                </tr>\r\n  " +
"                              <tr>\r\n                                    <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Endorsement/Audit Premium</td>\r\n                                    <td>{{data.T" +
"otalAuditAndEndorsementAmount | currency:\"$\":0}}</td>\r\n                         " +
"           <td");

WriteLiteral(" class=\"tableBorder forecasting\"");

WriteLiteral(">\r\n                                        <input");

WriteLiteral(" title=\"Outstanding Quoted & Un-Quoted Premium\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" ng-model=\"forecastAmount\"");

WriteLiteral(" fcsa-number=\"{ prepend: \'$\' }\"");

WriteLiteral(" />\r\n                                    </td>\r\n                                <" +
"/tr>\r\n                                <tr>\r\n                                    " +
"<td");

WriteLiteral(" class=\"header bg-yellow\"");

WriteLiteral(">Total Booked Renewal & New Business Plus Installments</td>\r\n                    " +
"                <td");

WriteLiteral(" class=\"bg-yellow\"");

WriteLiteral(">{{data.TotalBookedPlusInstallments | currency:\"$\":0}}</td>\r\n                    " +
"                <td");

WriteLiteral(" class=\"tableBorder forecasting bg-yellow\"");

WriteLiteral(">{{formatNumeric(forecastAmount) + parseFloat(data.TotalBookedPlusInstallments) |" +
" currency:\"$\":0}}</td>\r\n                                </tr>\r\n                 " +
"               <tr>\r\n                                    <td");

WriteLiteral(" class=\"header bg-red-active\"");

WriteLiteral(">Budget</td>\r\n                                    <td");

WriteLiteral(" class=\"bg-red-active\"");

WriteLiteral(">{{data.Budget | currency:\"$\":0}}</td>\r\n                                    <td");

WriteLiteral(" class=\"tableBorder forecasting bg-red-active\"");

WriteLiteral(">{{data.Budget | currency:\"$\":0}}</td>\r\n                                </tr>\r\n  " +
"                              <tr>\r\n                                    <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Over/Under Budget Percentage</td>\r\n                                    <td>{{dat" +
"a.OverUnderPercent}} %</td>\r\n                                    <td");

WriteLiteral(" class=\"tableBorder\"");

WriteLiteral(@">{{(((formatNumeric(forecastAmount) + parseFloat(data.TotalBookedPlusInstallments)) / parseFloat(data.Budget)) - 1) * 100 | number:2}} %</td>
                                </tr>
                                <tr>
                                    <td");

WriteLiteral(" class=\"header warning\"");

WriteLiteral(">{{year}} YTD Actual</td>\r\n                                    <td");

WriteLiteral(" class=\"warning\"");

WriteLiteral(">{{data.YTDActual | currency:\"$\":0}}</td>\r\n                                    <t" +
"d");

WriteLiteral(" class=\"tableBorder forecasting warning\"");

WriteLiteral(">{{formatNumeric(forecastAmount) + parseFloat(data.YTDActual) + parseFloat(totalF" +
"orecastAmount) | currency:\"$\":0}}</td>\r\n                                </tr>\r\n " +
"                               <tr>\r\n                                    <td");

WriteLiteral(" class=\"header bg-red-active\"");

WriteLiteral(">{{year}} YTD Budget</td>\r\n                                    <td");

WriteLiteral(" class=\"bg-red-active\"");

WriteLiteral(">{{data.YTDBudget | currency:\"$\":0}}</td>\r\n                                    <t" +
"d");

WriteLiteral(" class=\"tableBorder forecasting bg-red-active\"");

WriteLiteral(">{{data.YTDBudget | currency:\"$\":0}}</td>\r\n                                </tr>\r" +
"\n                                <tr>\r\n                                    <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(">{{year}} YTD Over/Under Budget</td>\r\n                                    <td>{{d" +
"ata.YTDOverUnderBudgetPercent}} %</td>\r\n                                    <td");

WriteLiteral(" class=\"tableBorder\"");

WriteLiteral(@">{{(((formatNumeric(forecastAmount) + parseFloat(data.YTDActual) + parseFloat(totalForecastAmount))/parseFloat(data.YTDBudget)) - 1) * 100 | number:2}} %</td>
                                </tr>
                            </tbody>
                        </table>
                    </div><!-- /.box-body -->
                </div>
            </div>

            <div");

WriteLiteral(" class=\"col-lg-8 col-md-6\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"box box-solid\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box-header with-border\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">{{month.Name}} Branch Summary</h3>\r\n                    </div><!-- /.box-header " +
"-->\r\n                    <div");

WriteLiteral(" class=\"box-body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(" style=\"font-size:16px\"");

WriteLiteral(">\r\n                            <table");

WriteLiteral(" class=\"table table-hover\"");

WriteLiteral(@">
                                <thead>
                                    <tr>
                                        <th>Branch</th>
                                        <th>Renewals</th>
                                        <th>Expiring Booked</th>
                                        <th>NB Written</th>
                                        <th>NB Booked</th>
                                        <th>Audits</th>
                                        <th>Endorsements</th>
                                        <th>Installments</th>
                                        <th>Totals</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr");

WriteLiteral(" ng-repeat=\"branchSum in branchSummary\"");

WriteLiteral(">\r\n                                        <td");

WriteLiteral(" class=\"header\"");

WriteLiteral(@">{{branchSum.Territory}}</td>
                                        <td>{{branchSum.RenewalWrittenPremium | currency:""$"":0}}</td>
                                        <td>{{branchSum.ExpiringBookedPremium | currency:""$"":0}}</td>
                                        <td>{{branchSum.NewBusinessWritten | currency:""$"":0}}</td>
                                        <td>{{branchSum.NewBusinessBookedPremium | currency:""$"":0}}</td>
                                        <td>{{branchSum.AuditPremium | currency:""$"":0}}</td>
                                        <td>{{branchSum.EndorsementPremium | currency:""$"":0}}</td>
                                        <td>{{branchSum.Installments | currency:""$"":0}}</td>
                                        <td>{{branchSum.Total | currency:""$"":0}}</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div><!-- /.box-body -->
                </div>
            </div>
        </div>
        <!-- #endregion -->
        <!-- #region Risk Grid -->
        <div");

WriteLiteral(" class=\"consoleRiskGrids\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-lg-12 col-md-12 col-sm-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"box box-solid\"");

WriteLiteral(" ng-show=\"month.Month && showDetail\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box-header with-border\"");

WriteLiteral(" style=\"background-color: #001F3F;color: white;\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral("><strong> --- {{month.Name}} RENEWALS ---</strong></h3>\r\n                        " +
"<div");

WriteLiteral(" class=\"box-tools pull-right\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-box-tool text-white dx-font-l\"");

WriteLiteral(" ng-click=\"exportRenewals()\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file\"");

WriteLiteral("></i></button>\r\n                            <button");

WriteLiteral(" class=\"btn btn-box-tool\"");

WriteLiteral(" data-widget=\"collapse\"");

WriteLiteral(" title=\"Collapse\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-minus\"");

WriteLiteral("></i></button>\r\n                        </div>\r\n                    </div>\r\n     " +
"               <div");

WriteLiteral(" class=\"box-body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"plc_renewalRisks\"");

WriteLiteral(" dx-data-grid=\"renewalGridSettings\"");

WriteLiteral("></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n" +
"\r\n            <div");

WriteLiteral(" class=\"col-lg-12 col-md-12 col-sm-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"box box-solid\"");

WriteLiteral(" ng-show=\"month.Month && showDetail\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"box-header with-border\"");

WriteLiteral(" style=\"background-color: #001F3F;color: white;\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral("><strong> --- {{month.Name}} NEW BUSINESS --- </strong></h3>\r\n                   " +
"     <div");

WriteLiteral(" class=\"box-tools pull-right\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-box-tool text-white dx-font-l\"");

WriteLiteral(" ng-click=\"exportNewBusiness()\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-file\"");

WriteLiteral("></i></button>\r\n                            <button");

WriteLiteral(" class=\"btn btn-box-tool\"");

WriteLiteral(" data-widget=\"collapse\"");

WriteLiteral(" title=\"Collapse\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-minus\"");

WriteLiteral("></i></button>\r\n                        </div>\r\n                    </div>\r\n     " +
"               <div");

WriteLiteral(" class=\"box-body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" id=\"plc_newBusinessRisks\"");

WriteLiteral(" dx-data-grid=\"newBusinessGridSettings\"");

WriteLiteral("></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n" +
"        </div>\r\n        <!-- #endregion -->\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
