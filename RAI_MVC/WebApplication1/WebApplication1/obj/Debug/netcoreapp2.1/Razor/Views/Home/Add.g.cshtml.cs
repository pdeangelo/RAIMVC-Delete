#pragma checksum "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e996d3b07d13a4d720e24b19420b41d8b2bef25c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Add), @"mvc.1.0.view", @"/Views/Home/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Add.cshtml", typeof(AspNetCore.Views_Home_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e996d3b07d13a4d720e24b19420b41d8b2bef25c", @"/Views/Home/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RAI_MVC.Models.Loan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Add.cshtml"
  
    ViewBag.Title = "Add Loan";

#line default
#line hidden
            BeginContext(68, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(75, 13, false);
#line 6 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Add.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(88, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(98, 25, false);
#line 8 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Add.cshtml"
Write(Html.Partial("_LoanForm"));

#line default
#line hidden
            EndContext();
            BeginContext(123, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RAI_MVC.Models.Loan> Html { get; private set; }
    }
}
#pragma warning restore 1591
