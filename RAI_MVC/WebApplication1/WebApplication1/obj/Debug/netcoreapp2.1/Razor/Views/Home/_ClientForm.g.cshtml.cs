#pragma checksum "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a309b0e4125d47dcdda503f574d476773af7af9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ClientForm), @"mvc.1.0.view", @"/Views/Home/_ClientForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_ClientForm.cshtml", typeof(AspNetCore.Views_Home__ClientForm))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#line 2 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
using RAI_MVC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a309b0e4125d47dcdda503f574d476773af7af9", @"/Views/Home/_ClientForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ClientForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RAI_MVC.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(83, 97, false);
#line 6 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
Write(Html.ValidationSummary("The following errors were found:", new { @class = "alert alert-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(182, 113, true);
            WriteLiteral("<div class=\"row\">\r\n\r\n    <div class=\"col-md-6 col-lg-offset-3\">\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(296, 31, false);
#line 12 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.HiddenFor(m => m.ClientID));

#line default
#line hidden
            EndContext();
            BeginContext(327, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(342, 31, false);
#line 13 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.HiddenFor(m => m.ClientID));

#line default
#line hidden
            EndContext();
            BeginContext(373, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(438, 66, false);
#line 16 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.ClientName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(504, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(519, 67, false);
#line 17 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.ClientName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(586, 66, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(653, 67, false);
#line 21 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.AdvanceRate, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(720, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(735, 68, false);
#line 22 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.AdvanceRate, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(803, 66, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(870, 71, false);
#line 26 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.MinimumInterest, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(941, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(956, 72, false);
#line 27 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.MinimumInterest, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1093, 75, false);
#line 30 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.OriginationDiscount, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1183, 76, false);
#line 31 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.OriginationDiscount, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1324, 76, false);
#line 34 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.OriginationDiscount2, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1415, 77, false);
#line 35 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.OriginationDiscount2, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 66, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1559, 82, false);
#line 39 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.OriginationDiscountNumDays, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1656, 83, false);
#line 40 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.OriginationDiscountNumDays, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 66, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1806, 83, false);
#line 44 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.OriginationDiscountNumDays2, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1904, 84, false);
#line 45 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.OriginationDiscountNumDays2, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 135, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"checkbox\">\r\n                <label>\r\n                    ");
            EndContext();
            BeginContext(2124, 69, false);
#line 51 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
               Write(Html.CheckBox("InterestBasedOnAdvance", Model.InterestBasedOnAdvance));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2195, 50, false);
#line 51 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
                                                                                      Write(Html.DisplayNameFor(m => m.InterestBasedOnAdvance));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 183, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"checkbox\">\r\n                <label>\r\n                    ");
            EndContext();
            BeginContext(2429, 75, false);
#line 60 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
               Write(Html.CheckBox("OriginationBasedOnAdvance", Model.OriginationBasedOnAdvance));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2506, 53, false);
#line 60 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
                                                                                            Write(Html.DisplayNameFor(m => m.OriginationBasedOnAdvance));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 181, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"checkbox\">\r\n                <label>\r\n                    ");
            EndContext();
            BeginContext(2741, 45, false);
#line 68 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
               Write(Html.CheckBox("NoInterest", Model.NoInterest));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2788, 38, false);
#line 68 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
                                                              Write(Html.DisplayNameFor(m => m.NoInterest));

#line default
#line hidden
            EndContext();
            BeginContext(2826, 112, true);
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2939, 71, false);
#line 74 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.ClientPrimeRate, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3010, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3025, 72, false);
#line 75 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.ClientPrimeRate, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3097, 66, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(3164, 77, false);
#line 79 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.LabelFor(m => m.ClientPrimeRateSpread, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3241, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3256, 78, false);
#line 80 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
       Write(Html.TextBoxFor(m => m.ClientPrimeRateSpread, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3334, 290, true);
            WriteLiteral(@"
        </div>

        <div class=""col-md-12"">
            <div class=""pad-top"">
                <button type=""submit"" class=""btn btn-success btn-lg margin-right"">
                    <span class=""glyphicon glyphicon-save""></span> Save
                </button>
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3624, "\"", 3653, 1);
#line 88 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
WriteAttributeValue("", 3631, Url.Action("Clients"), 3631, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3654, 195, true);
            WriteLiteral(" class=\"btn btn-warning btn-lg\">\r\n                    <span class=\"glyphicon glyphicon-remove\"></span> Cancel\r\n                </a>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    </div>\r\n");
            EndContext();
#line 96 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_ClientForm.cshtml"
}

#line default
#line hidden
            BeginContext(3852, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RAI_MVC.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591