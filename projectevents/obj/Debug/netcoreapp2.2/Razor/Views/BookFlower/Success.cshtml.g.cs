#pragma checksum "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa6e8bf9b27932f98bb92e7ec0cf3112c29010e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookFlower_Success), @"mvc.1.0.view", @"/Views/BookFlower/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookFlower/Success.cshtml", typeof(AspNetCore.Views_BookFlower_Success))]
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
#line 1 "D:\Project-Events\projectevents\projectevents\projectevents\Views\_ViewImports.cshtml"
using projectevents;

#line default
#line hidden
#line 2 "D:\Project-Events\projectevents\projectevents\projectevents\Views\_ViewImports.cshtml"
using projectevents.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa6e8bf9b27932f98bb92e7ec0cf3112c29010e5", @"/Views/BookFlower/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00d2d6fec79dc449d350a996f52054159e79a8a", @"/Views/_ViewImports.cshtml")]
    public class Views_BookFlower_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\Success.cshtml"
  
    Layout = "~/Views/Shared/_LayoutCustomer.cshtml";

#line default
#line hidden
#line 4 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\Success.cshtml"
 if (ViewData["BookingFlowerMessage"] != null)
{

#line default
#line hidden
            BeginContext(113, 55, true);
            WriteLiteral("    <p class=\"alert alert-success\" id=\"successMessage\">");
            EndContext();
            BeginContext(169, 32, false);
#line 6 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\Success.cshtml"
                                                  Write(ViewData["BookingFlowerMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(201, 72, true);
            WriteLiteral("</p>\r\n    <h3>Process Completed Download Receipt</h3>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(274, 64, false);
#line 9 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\Success.cshtml"
   Write(Html.ActionLink("Show Receipt", "AllBookings", "ShowAllBooking"));

#line default
#line hidden
            EndContext();
            BeginContext(338, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 11 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\Success.cshtml"
}

#line default
#line hidden
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
