#pragma checksum "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba619a094541b080ff4a5b556148d3d31e01aa85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookFlower_BookFlower), @"mvc.1.0.view", @"/Views/BookFlower/BookFlower.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookFlower/BookFlower.cshtml", typeof(AspNetCore.Views_BookFlower_BookFlower))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba619a094541b080ff4a5b556148d3d31e01aa85", @"/Views/BookFlower/BookFlower.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b00d2d6fec79dc449d350a996f52054159e79a8a", @"/Views/_ViewImports.cshtml")]
    public class Views_BookFlower_BookFlower : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projectevents.Models.BookingFlower>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BookFlower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookFlower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
  
    Layout = "~/Views/Shared/_LayoutCustomer.cshtml";

#line default
#line hidden
            BeginContext(105, 29, true);
            WriteLiteral("<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(134, 1046, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba619a094541b080ff4a5b556148d3d31e01aa855435", async() => {
                BeginContext(206, 177, true);
                WriteLiteral("\r\n        <div class=\"col-xs-offset-0 col-xs-4\">\r\n            <h3><span class=\"label label-info\">Book Flowers</span></h3>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(384, 28, false);
#line 10 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
                BeginContext(412, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(431, 23, false);
#line 11 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(454, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 12 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                 for (int i = 0; i < Model.FlowerList.Count(); i++)
                {

#line default
#line hidden
                BeginContext(544, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(564, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba619a094541b080ff4a5b556148d3d31e01aa857135", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 14 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FlowerList[i].FlowerChecked);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(634, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(656, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba619a094541b080ff4a5b556148d3d31e01aa859007", async() => {
                    BeginContext(704, 30, false);
#line 15 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                                                              Write(Model.FlowerList[i].FlowerName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 15 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FlowerList[i].FlowerID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(742, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(764, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba619a094541b080ff4a5b556148d3d31e01aa8510990", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 16 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FlowerList[i].FlowerID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(827, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(849, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba619a094541b080ff4a5b556148d3d31e01aa8512858", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 17 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FlowerList[i].FlowerName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(914, 30, true);
                WriteLiteral("\r\n                    <br />\r\n");
                EndContext();
#line 19 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                }

#line default
#line hidden
                BeginContext(963, 210, true);
                WriteLiteral("                <div class=\"form-actions\">\r\n                    <input id=\"Submit\" type=\"submit\" class=\"btn btn-success\" value=\"Book Flowers\" />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1180, 109, true);
            WriteLiteral("\r\n    <div class=\"col-xs-offset-0 col-xs-6\">\r\n        <div id=\"wrap\">\r\n            <div id=\"slider-holder\">\r\n");
            EndContext();
#line 29 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                  
                    var data = (List<projectevents.Models.Flower>)ViewBag.SliderFlowerImages;

                    for (int i = 0; i < (data.Count()); i++)
                    {

#line default
#line hidden
            BeginContext(1491, 109, true);
            WriteLiteral("                        <div class=\"slide\">\r\n                            <div style=\"background-color:black\">");
            EndContext();
            BeginContext(1601, 18, false);
#line 35 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                                                           Write(data[i].FlowerName);

#line default
#line hidden
            EndContext();
            BeginContext(1619, 40, true);
            WriteLiteral("</div>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1659, "\"", 1689, 2);
            WriteAttributeValue("", 1665, "/", 1665, 1, true);
#line 36 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
WriteAttributeValue("", 1666, data[i].FlowerFilePath, 1666, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1690, 25, true);
            WriteLiteral(" width=\"400\" height=\"300\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 1715, "\"", 1740, 1);
#line 36 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
WriteAttributeValue("", 1721, data[i].FlowerName, 1721, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1741, 86, true);
            WriteLiteral(">\r\n                        </div>\r\n                        <div id=\"btn-nav-holder\">\r\n");
            EndContext();
#line 39 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                             if (i == 0)
                            {

#line default
#line hidden
            BeginContext(1900, 99, true);
            WriteLiteral("                                <img src=\"/images/bn-slide-on.png\" width=\"8\" height=\"8\" alt=\"\" />\r\n");
            EndContext();
#line 42 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2095, 100, true);
            WriteLiteral("                                <img src=\"/images/bn-slide-off.png\" width=\"8\" height=\"8\" alt=\"\" />\r\n");
            EndContext();
#line 46 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                            }

#line default
#line hidden
            BeginContext(2226, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#line 48 "D:\Project-Events\projectevents\projectevents\projectevents\Views\BookFlower\BookFlower.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2300, 100, true);
            WriteLiteral("            </div>\r\n            <div style=\"clear: both;\"></div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projectevents.Models.BookingFlower> Html { get; private set; }
    }
}
#pragma warning restore 1591
