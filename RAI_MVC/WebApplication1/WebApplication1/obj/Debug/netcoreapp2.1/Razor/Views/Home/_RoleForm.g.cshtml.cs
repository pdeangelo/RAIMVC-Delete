#pragma checksum "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb896c609cc28bfb4f6474981430cdcc65a601c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__RoleForm), @"mvc.1.0.view", @"/Views/Home/_RoleForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_RoleForm.cshtml", typeof(AspNetCore.Views_Home__RoleForm))]
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
#line 2 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml"
using RAI_MVC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb896c609cc28bfb4f6474981430cdcc65a601c3", @"/Views/Home/_RoleForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__RoleForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RAI_MVC.Models.Role>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(81, 97, false);
#line 6 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml"
Write(Html.ValidationSummary("The following errors were found:", new { @class = "alert alert-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(180, 113, true);
            WriteLiteral("<div class=\"row\">\r\n\r\n    <div class=\"col-md-6 col-lg-offset-3\">\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(294, 29, false);
#line 12 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml"
       Write(Html.HiddenFor(m => m.RoleID));

#line default
#line hidden
            EndContext();
            BeginContext(323, 74, true);
            WriteLiteral("\r\n        </div>\r\n        \r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(398, 64, false);
#line 16 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml"
       Write(Html.LabelFor(m => m.RoleName, new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(462, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(477, 65, false);
#line 17 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml"
       Write(Html.TextBoxFor(m => m.RoleName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(542, 290, true);
            WriteLiteral(@"
        </div>

        <div class=""col-md-12"">
            <div class=""pad-top"">
                <button type=""submit"" class=""btn btn-success btn-lg margin-right"">
                    <span class=""glyphicon glyphicon-save""></span> Save
                </button>
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 832, "\"", 859, 1);
#line 25 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml"
WriteAttributeValue("", 839, Url.Action("Roles"), 839, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(860, 195, true);
            WriteLiteral(" class=\"btn btn-warning btn-lg\">\r\n                    <span class=\"glyphicon glyphicon-remove\"></span> Cancel\r\n                </a>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    </div>\r\n");
            EndContext();
#line 33 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\_RoleForm.cshtml"
}

#line default
#line hidden
            BeginContext(1058, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RAI_MVC.Models.Role> Html { get; private set; }
    }
}
#pragma warning restore 1591