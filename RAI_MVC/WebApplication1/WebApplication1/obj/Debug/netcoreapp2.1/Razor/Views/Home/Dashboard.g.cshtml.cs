#pragma checksum "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9c9ec902b3a00ee314a3a3fc7452529799d5fab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9c9ec902b3a00ee314a3a3fc7452529799d5fab", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Dashboard.cshtml"
  
    ViewBag.Title = "Dashboard Report";

#line default
#line hidden
            BeginContext(48, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(53, 13, false);
#line 4 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Dashboard.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(66, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 5 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Dashboard.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
            BeginContext(111, 236, true);
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible\" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n        ");
            EndContext();
            BeginContext(348, 19, false);
#line 11 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Dashboard.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(367, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\Dashboard.cshtml"
}

#line default
#line hidden
            BeginContext(384, 267, true);
            WriteLiteral(@"<iframe title=""RAIGroup"" width=""1500"" height=""700"" src=""https://app.powerbi.com/view?r=eyJrIjoiZmU4MDdjZjUtOTFmZC00ZDU2LTgxYWMtMTk1NTBhZDQ1MjMxIiwidCI6IjcyOWQxY2U4LTUxN2EtNGJjYi1iY2JlLTgzYThmNzJkYzMzMSIsImMiOjF9"" frameborder=""0"" allowFullScreen=""true""></iframe>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591