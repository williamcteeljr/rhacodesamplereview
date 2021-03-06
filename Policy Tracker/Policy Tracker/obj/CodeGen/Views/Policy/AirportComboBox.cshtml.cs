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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Policy/AirportComboBox.cshtml")]
    public partial class _Views_Policy_AirportComboBox_cshtml : System.Web.Mvc.WebViewPage<PolicyTracker.DomainModel.Policy.Aircraft>
    {
        public _Views_Policy_AirportComboBox_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Policy\AirportComboBox.cshtml"
Write(Html.DevExpress().ComboBoxFor(model => Model.AirportID,
    settings =>
    {
        settings.Name = "AirportID";
        settings.SelectedIndex = 0;
        settings.Properties.DropDownWidth = 550;
        settings.Properties.DropDownStyle = DropDownStyle.DropDownList;
        settings.CallbackRouteValues = new { Controller = "Policy", Action = "AirportComboBox" };
        settings.Properties.CallbackPageSize = 30;
        settings.Properties.FilterMinLength = 1;
        settings.Properties.IncrementalFilteringDelay = 30;
        settings.Properties.ClearButton.Visibility = AutoBoolean.True;
        settings.Properties.TextFormatString = "[{0}] {1}";
        settings.Properties.TextField = "AirportName";
        settings.Properties.ValueField = "AirportID";
        settings.Properties.ValueType = typeof(string);
        settings.ControlStyle.CssClass = "form-control";

        settings.Properties.Columns.Add("AirportID", "AirportID", 60);
        settings.Properties.Columns.Add("AirportName", "AirportName", 130);
        settings.Properties.Columns.Add("State", "State", 100);
        settings.Properties.Columns.Add("City", "City", 100);
        settings.Properties.Columns.Add("AirportUse", "AirportUse", 60);

        settings.Properties.ClientSideEvents.SelectedIndexChanged = "ora.Risk.AirportIndexChange";

        settings.ShowModelErrors = true;

        settings.PreRender = (s, e) =>
        {
            MVCxComboBox combo = s as MVCxComboBox;
            if (!String.IsNullOrEmpty(Model.AirportID))
            {
                combo.Value = Model.AirportID;
                combo.DataBind();
            }
        };
    }
).BindList(DXServiceLocator.AirportComboSvc.ItemRequestByFilter, DXServiceLocator.AirportComboSvc.ItemRequestByValue).Bind(Model.AirportID).GetHtml());

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
