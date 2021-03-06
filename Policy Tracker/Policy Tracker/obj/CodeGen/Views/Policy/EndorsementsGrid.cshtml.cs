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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Policy/EndorsementsGrid.cshtml")]
    public partial class _Views_Policy_EndorsementsGrid_cshtml : System.Web.Mvc.WebViewPage<List<PolicyTracker.DomainModel.Policy.RiskEndorsement>>
    {
        public _Views_Policy_EndorsementsGrid_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Policy\EndorsementsGrid.cshtml"
Write(Html.DevExpress().GridView(
    settings =>
    {
        settings.Name = "RiskEndorsements";
        settings.KeyFieldName = "Id";
        settings.Width = System.Web.UI.WebControls.Unit.Percentage(100);
        settings.Height = System.Web.UI.WebControls.Unit.Pixel(100);
        settings.Settings.HorizontalScrollBarMode = ScrollBarMode.Hidden;
        settings.Settings.VerticalScrollBarMode = ScrollBarMode.Visible;
        settings.Settings.VerticalScrollableHeight = 150;
        settings.CallbackRouteValues = new { Controller = "Policy", Action = "EndorsementsGrid", riskId = (int)ViewBag.RiskId };
        settings.SettingsEditing.BatchUpdateRouteValues = new { Controller = "Policy", Action = "BatchEndorsements", riskId = (int)ViewBag.RiskId };

        settings.ClientSideEvents.EndCallback = @"
            function(s, e) {
                $.get( '/policytracker/policy/RiskPremiumContent/" + (int)ViewBag.RiskId + @"', function(data) {
                    $('#RiskPremiumContent').html(data);   
                })
                .done(function() {})
                .fail(function() { alert('Error fetching updated premium information. Please close and reopen this risk to see updated premium information.')})
            }";

        //if (ViewBag.IsEditable)
        //{
        settings.SettingsEditing.BatchUpdateRouteValues = new { Controller = "Policy", Action = "BatchEndorsements", riskId = (int)ViewBag.RiskId };
        settings.SettingsEditing.Mode = GridViewEditingMode.Batch;
        settings.SettingsEditing.BatchEditSettings.EditMode = GridViewBatchEditMode.Cell;
        settings.SettingsEditing.BatchEditSettings.StartEditAction = GridViewBatchStartEditAction.Click;
        settings.SettingsCommandButton.CancelButton.ButtonType = GridCommandButtonRenderMode.Button;
        settings.SettingsCommandButton.UpdateButton.ButtonType = GridCommandButtonRenderMode.Button;
        settings.CommandColumn.Visible = true;
        settings.CommandColumn.ShowDeleteButton = true;
        settings.CommandColumn.ShowNewButtonInHeader = true;
        settings.CommandColumn.ButtonType = GridCommandButtonRenderMode.Button;
        settings.CommandColumn.Width = 70;
        //}

        settings.Columns.Add(column => {
            column.FieldName = "Id";
            column.Visible = false;
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "RiskId";
            column.Visible = false;
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "Code";
            column.Caption = "Form Id";
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "Description";
            column.Caption = "Form Name";
        });

        settings.Columns.Add(column => {
            column.FieldName = "EffectiveDate";
            column.Caption = "Effective Date";
            column.ColumnType = MVCxGridViewColumnType.DateEdit;
            var deSettings = column.PropertiesEdit as DateEditProperties;
            deSettings.EditFormat = EditFormat.Custom;
            deSettings.EditFormatString = "M/dd/yyyy";
            deSettings.DisplayFormatString = "M/dd/yyyy";
        });

        settings.Columns.Add(column => {
            column.FieldName = "Premium";
            column.Caption = "Annualized Premium";
            column.ColumnType = MVCxGridViewColumnType.TextBox;
            var tbSettings = column.PropertiesEdit as TextBoxProperties;
            tbSettings.MaskSettings.AllowMouseWheel = false;
            tbSettings.MaskSettings.Mask = "<-999999999..999999999g>";
            tbSettings.MaskSettings.IncludeLiterals = MaskIncludeLiteralsMode.DecimalSymbol;
            tbSettings.DisplayFormatString = "C0";
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "RateType";
            column.Caption = "Premium Type";

            column.ColumnType = MVCxGridViewColumnType.ComboBox;
            var comboBoxProperties = column.PropertiesEdit as ComboBoxProperties;
            comboBoxProperties.DataSource = new[] { "Flat", "Pro Rated" };
            comboBoxProperties.ValueType = typeof(string);
        });

        settings.Columns.Add(column =>
        {
            column.FieldName = "InvoicedPremium";
            column.Caption = "Invoiced Prem (Written)";
            column.ColumnType = MVCxGridViewColumnType.TextBox;
            var tbSettings = column.PropertiesEdit as TextBoxProperties;
            tbSettings.MaskSettings.AllowMouseWheel = false;
            tbSettings.MaskSettings.Mask = "<-999999999..999999999g>";
            tbSettings.MaskSettings.IncludeLiterals = MaskIncludeLiteralsMode.DecimalSymbol;
            tbSettings.DisplayFormatString = "C0";
        });

        settings.Columns.Add(column =>
        {
            column.Name = "";
            column.FieldName = "IsCarryOverforRenewal";
            column.Caption = "Renewal Carry Over";
            column.ColumnType = MVCxGridViewColumnType.CheckBox;
            var cbsettings = column.PropertiesEdit as CheckBoxProperties;
        });

        settings.Columns.Add(column =>
        {
            column.Name = "";
            column.FieldName = "IsFullyEarned";
            column.Caption = "Fully Earned";
            column.ColumnType = MVCxGridViewColumnType.CheckBox;
            var cbsettings = column.PropertiesEdit as CheckBoxProperties;
        });

        settings.InitNewRow = (sender, e) =>
        {
            e.NewValues["IsCarryOverforRenewal"] = true;
            e.NewValues["IsFullyEarned"] = false;
            e.NewValues["Premium"] = 0;
            e.NewValues["InvoicedPremium"] = 0;
        };
    }).Bind(Model).GetHtml());

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
