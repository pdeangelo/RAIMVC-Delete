#pragma checksum "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\SalesReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "450795dbb51b7a129329b864b447717b7dcfc178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SalesReport), @"mvc.1.0.view", @"/Views/Home/SalesReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SalesReport.cshtml", typeof(AspNetCore.Views_Home_SalesReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450795dbb51b7a129329b864b447717b7dcfc178", @"/Views/Home/SalesReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SalesReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RAI_MVC.Models.FromToDate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\SalesReport.cshtml"
  
    ViewBag.Title = "Sales Report";

#line default
#line hidden
            BeginContext(78, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(85, 13, false);
#line 6 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\SalesReport.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(98, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 7 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\SalesReport.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
            BeginContext(143, 236, true);
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible\" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n        ");
            EndContext();
            BeginContext(380, 19, false);
#line 13 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\SalesReport.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(399, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\SalesReport.cshtml"
}

#line default
#line hidden
            BeginContext(416, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\SalesReport.cshtml"
 using (Html.BeginForm("SalesReport", "RAI", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(485, 1038, true);
            WriteLiteral(@"    <div class=""container"">
        <div id=""wrapper"" class=""clearfix"">
            <div class=""well"">
                <div class=""form-horizontal"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <label for=""FDate"">From Date</label>
                            <input type=""date"" ng-model=""FDate"" id=""FDate"" name=""FDate"" class=""form-control"" required />
                        </div>
                        <div class=""col-md-4"">
                            <label for=""lblTDate"">To Date</label>
                            <input type=""date"" ng-model=""TDate"" id=""TDate"" name=""TDate"" class=""form-control"" required />
                        </div>
                    </div>
                    <hr />
                    <div class=""form-group"">
                        <p><button class=""btn btn-lg btn-success"" onclick=""salesReport()"">Go</button></p>
                    </div>
                </div>
            </div>
        </div>");
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 41 "C:\Users\pdean\Documents\SourceCode\RAI_MVC\RAIMVC\RAI_MVC\WebApplication1\WebApplication1\Views\Home\SalesReport.cshtml"
}

#line default
#line hidden
            BeginContext(1526, 303, true);
            WriteLiteral(@"<script type=""text/javascript"">
    function salesReport() {
        var fd = document.getElementById(""FDate"");
        var td = document.getElementById(""TDate"");
        $.post(""/RAI/RunSalesReport/"", { dtFromDate: fd.value, dtToDate: td.value }, function (r) {

        });
    }
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RAI_MVC.Models.FromToDate> Html { get; private set; }
    }
}
#pragma warning restore 1591
