#pragma checksum "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21b11acab7385213e75bede6f8d7d7e62e7a696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c21b11acab7385213e75bede6f8d7d7e62e7a696", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RAI_MVC.Models.Loan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Detail.cshtml"
      
        Layout = "~/Views/Shared/_Layout.cshtml";
        ViewBag.Title = "Loans";
        ViewBag.ShowBackbar = true;
    

#line default
#line hidden
            BeginContext(165, 10, true);
            WriteLiteral("\r\n    <h2>");
            EndContext();
            BeginContext(176, 16, false);
#line 8 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Detail.cshtml"
   Write(Model.LoanNumber);

#line default
#line hidden
            EndContext();
            BeginContext(192, 158, true);
            WriteLiteral("</h2>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"well\">\r\n                <h5><label>Loan ID:</label> <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 350, "\"", 371, 1);
#line 13 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Detail.cshtml"
WriteAttributeValue("", 358, Model.LoanID, 358, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(372, 74, true);
            WriteLiteral(" /></h5>\r\n                <h5><label>Loan Name:</label> <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 446, "\"", 471, 1);
#line 14 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Detail.cshtml"
WriteAttributeValue("", 454, Model.LoanNumber, 454, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(472, 82, true);
            WriteLiteral(" /></h5>\r\n                <h5><label>Loan Funding Date:</label> <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 554, "\"", 584, 1);
#line 15 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Detail.cshtml"
WriteAttributeValue("", 562, Model.LoanFundingDate, 562, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(585, 85, true);
            WriteLiteral(" /></h5>\r\n                <h5><label>Loan Mortgage Amount:</label> <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 670, "\"", 703, 1);
#line 16 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Detail.cshtml"
WriteAttributeValue("", 678, Model.LoanMortgageAmount, 678, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(704, 86, true);
            WriteLiteral(" /></h5>\r\n\r\n            </div>\r\n            \r\n        </div>\r\n        \r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RAI_MVC.Models.Loan> Html { get; private set; }
    }
}
#pragma warning restore 1591
