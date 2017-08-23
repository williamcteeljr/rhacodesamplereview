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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Policy/AircraftMakeComboBox.cshtml")]
    public partial class _Views_Policy_AircraftMakeComboBox_cshtml : System.Web.Mvc.WebViewPage<PolicyTracker.DomainModel.Policy.Aircraft>
    {
        public _Views_Policy_AircraftMakeComboBox_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Policy\AircraftMakeComboBox.cshtml"
Write(Html.DevExpress().ComboBox(settings => {
    settings.Name = "Make";

    settings.Properties.DropDownStyle = DropDownStyle.DropDown;
    settings.CallbackRouteValues = new { Controller = "Policy", Action = "AircraftMakeComboBox" };
    settings.Properties.CallbackPageSize = 30;
    settings.Properties.FilterMinLength = 3;
    settings.Properties.IncrementalFilteringDelay = 30;
    settings.Properties.ClearButton.Visibility = AutoBoolean.True;

    settings.Properties.ValueType = typeof(string);

    settings.ControlStyle.CssClass = "form-control";
    settings.Properties.CallbackPageSize = 50;

    settings.Properties.ClientSideEvents.SelectedIndexChanged = "function(s, e) { ASPxClientControl.GetControlCollection().GetByName('ModelName').PerformCallback(); }";

}).BindList(DXServiceLocator.AircraftMakeComboService.ItemRequestByFilter, DXServiceLocator.AircraftMakeComboService.ItemRequestByValue).Bind(Model.Make).GetHtml());

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
