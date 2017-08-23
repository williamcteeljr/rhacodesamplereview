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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Policy/HazardGroupDetails.cshtml")]
    public partial class _Views_Policy_HazardGroupDetails_cshtml : System.Web.Mvc.WebViewPage<PolicyTracker.DomainModel.Policy.Exposure>
    {
        public _Views_Policy_HazardGroupDetails_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<form");

WriteLiteral(" id=\"HazardGroupEditForm\"");

WriteLiteral(" class=\"oraForm form-horizontal\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 4 "..\..\Views\Policy\HazardGroupDetails.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("    ");

            
            #line 6 "..\..\Views\Policy\HazardGroupDetails.cshtml"
Write(Html.HiddenFor(m => Model.ExposureID));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 7 "..\..\Views\Policy\HazardGroupDetails.cshtml"
Write(Html.HiddenFor(m => Model.QuoteId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 8 "..\..\Views\Policy\HazardGroupDetails.cshtml"
Write(Html.HiddenFor(m => Model.PolicyNumber));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Views\Policy\HazardGroupDetails.cshtml"
Write(Html.HiddenFor(m => Model.LocationID));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"col-lg-8\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"box box-primary\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"box-header with-border\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-plane\"");

WriteLiteral("></i>\r\n                <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">Hazard Group Details</h3>\r\n            </div><!-- /.box-header -->\r\n            " +
"<!-- form start -->\r\n            <div");

WriteLiteral(" class=\"box-body\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Hazard State</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 22 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.TextBoxFor(m => Model.HazardState, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Class Code:</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 29 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.TextBoxFor(m => Model.Class, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Hazard Group:</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 36 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.TextBoxFor(m => Model.HazardGroupCode, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Employee Type:</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 43 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.TextBoxFor(m => Model.EmployeeTypeName, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Payroll Total:</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 51 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.DevExpress().TextBoxFor(model => Model.EmployeePayroll, settings =>
                            {
                                settings.Name = "EmployeePayroll";
                                settings.ControlStyle.CssClass = "form-control";
                                settings.Properties.MaskSettings.Mask = "<0..99999999999g>";
                                settings.Properties.MaskSettings.IncludeLiterals = MaskIncludeLiteralsMode.DecimalSymbol;
                            }).Bind(Model.EmployeePayroll.ToString()).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Premium Total:</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 65 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.DevExpress().TextBoxFor(model => Model.EmployeePremium, settings =>
                            {
                                settings.Name = "EmployeePremium";
                                settings.ControlStyle.CssClass = "form-control";
                                settings.Properties.MaskSettings.Mask = "<0..99999999999g>";
                                settings.Properties.MaskSettings.IncludeLiterals = MaskIncludeLiteralsMode.DecimalSymbol;
                            }).Bind(Model.EmployeePremium.ToString()).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">State Premium Total:</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 79 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.DevExpress().TextBoxFor(model => Model.StatePremium, settings =>
                            {
                                settings.Name = "StatePremium";
                                settings.ControlStyle.CssClass = "form-control";
                                settings.Properties.MaskSettings.Mask = "<0..99999999999g>";
                                settings.Properties.MaskSettings.IncludeLiterals = MaskIncludeLiteralsMode.DecimalSymbol;
                            }).Bind(Model.StatePremium.ToString()).GetHtml());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Employee Count:</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 92 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.TextBoxFor(m => Model.EmployeeCount, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"col-lg-3 col-sm-3 control-label\"");

WriteLiteral(">Hazard Location:</label>\r\n                    <div");

WriteLiteral(" class=\"col-lg-9 col-sm-9\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 100 "..\..\Views\Policy\HazardGroupDetails.cshtml"
                   Write(Html.DropDownListFor(x => x.ExpSelectedItemsIds, Model.ExpOptionList, new { SelectionMode = "single", style = "width:100%" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                ");

WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div");

WriteLiteral(" class=\"col-lg-4\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"box box-danger\"");

WriteLiteral(">\r\n            <!-- form start -->\r\n            <div");

WriteLiteral(" class=\"box-body\"");

WriteLiteral(" style=\"text-align:center\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-ambulance\"");

WriteLiteral(" style=\"font-size:14em\"");

WriteLiteral("></i>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
