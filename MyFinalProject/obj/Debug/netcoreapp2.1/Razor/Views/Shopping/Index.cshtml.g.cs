#pragma checksum "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f960239faee60430285d01a91802d9c0d5e9ed87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shopping_Index), @"mvc.1.0.view", @"/Views/Shopping/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shopping/Index.cshtml", typeof(AspNetCore.Views_Shopping_Index))]
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
#line 1 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\_ViewImports.cshtml"
using MyFinalProject;

#line default
#line hidden
#line 2 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\_ViewImports.cshtml"
using MyFinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\_ViewImports.cshtml"
using MyFinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f960239faee60430285d01a91802d9c0d5e9ed87", @"/Views/Shopping/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3402bfbd9f5f5dc7b3a292be92ddac4ec0ccd351", @"/Views/_ViewImports.cshtml")]
    public class Views_Shopping_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/preloader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/basket.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(59, 28, true);
            WriteLiteral("\r\n<div id=\"preloader\">\r\n    ");
            EndContext();
            BeginContext(87, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f960239faee60430285d01a91802d9c0d5e9ed875526", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(125, 977, true);
            WriteLiteral(@"
</div>


<!--SubBanner start-->
<section id=""sub-banner"" style=""background-image: url(img/paw.jpg)"">
    <div class=""all-title-box"">
        <div class=""container "">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <h2>ABOUT US</h2>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                        <li class=""breadcrumb-item active"">Shop List</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!--SubBanner end-->
<!--Shopping  start-->
<section id=""shopping"">
    <div class=""container pt-3 pb-5"">
        <div class=""row heading-row justify-content-center pt-5 pb-5"">
            <h2 class=""section-title text-black"">
                Shopp For Them
            </h2>
        </div>
        <div class=""row heading-row justify-content-center pt-5 pb-5"">
");
            EndContext();
#line 37 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
             foreach (var item in Model.products)
            {

#line default
#line hidden
            BeginContext(1168, 199, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 col-sm-12 col-xs-12\">\r\n                    <div class=\"card-block\">\r\n                        <div class=\"foodName pt-2\">\r\n                            <p>");
            EndContext();
            BeginContext(1368, 9, false);
#line 42 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1377, 132, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-img-top text-center  \">\r\n                            ");
            EndContext();
            BeginContext(1509, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f960239faee60430285d01a91802d9c0d5e9ed878845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1519, "~/img/", 1519, 6, true);
#line 45 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
AddHtmlAttributeValue("", 1525, item.Image, 1525, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1577, 155, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"list-group-item d-flex \">\r\n                            <div class=\"price col-lg-6\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1732, "\"", 1754, 2);
            WriteAttributeValue("", 1740, "fas", 1740, 3, true);
#line 48 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
WriteAttributeValue(" ", 1743, item.Icon, 1744, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1755, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(1758, 10, false);
#line 48 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
                                                                              Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1768, 104, true);
            WriteLiteral(" </i></div>\r\n                            <div class=\"purchaseBasket add-to-cart col-lg-6\" data-id=\"/img/");
            EndContext();
            BeginContext(1873, 10, false);
#line 49 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
                                                                                      Write(item.Image);

#line default
#line hidden
            EndContext();
            BeginContext(1883, 47, true);
            WriteLiteral("\"\r\n                                 data-name=\"");
            EndContext();
            BeginContext(1931, 13, false);
#line 50 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
                                       Write(item.DataName);

#line default
#line hidden
            EndContext();
            BeginContext(1944, 484, true);
            WriteLiteral(@""" data-price=""3.24"">
                                <i class=""fas fa-shopping-basket"">
                                    <span class=""checkedBuy"">
                                        <i class=""d-none
									fas fa-check-circle""></i>
                                    </span>
                                </i><span class=""addToBasket"">+</span>
                            </div>
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 61 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2443, 889, true);
            WriteLiteral(@"        </div>

    </div>
</section>
<!--Shopping end-->
<!-- Modal -->
<div class=""modal fade"" id=""cart"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Cart</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <table class=""show-cart table"">
                </table>
                <div>Total price: $<span class=""total-cart""></span></div>
            </div>
         
        </div>
    </div>
</div>
<!--Modal end-->

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3349, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3355, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f960239faee60430285d01a91802d9c0d5e9ed8714608", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3393, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3399, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f960239faee60430285d01a91802d9c0d5e9ed8715864", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3437, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3490, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
