#pragma checksum "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd81263d47e959a1d5e12a3ce1ef4f22ab79ae28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\_ViewImports.cshtml"
using MVCAPP_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\_ViewImports.cshtml"
using MVCAPP_Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd81263d47e959a1d5e12a3ce1ef4f22ab79ae28", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399a3513df56d46ca666f882ed09f6b8336fba23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\Home\Index.cshtml"
Write(ViewBag.Myname1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\Home\Index.cshtml"
Write(ViewData["myname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h1>");
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\Home\Index.cshtml"
Write(TempData["myname1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\MVCAPP_Core\MVCAPP_Core\Views\Home\Index.cshtml"
Write(HttpContextAccessor.HttpContext.Session.GetString("myname3"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
