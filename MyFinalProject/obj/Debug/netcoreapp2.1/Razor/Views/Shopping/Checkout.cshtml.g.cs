#pragma checksum "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ead0e66d869c24f317d35d4422a45b17be369a08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shopping_Checkout), @"mvc.1.0.view", @"/Views/Shopping/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shopping/Checkout.cshtml", typeof(AspNetCore.Views_Shopping_Checkout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ead0e66d869c24f317d35d4422a45b17be369a08", @"/Views/Shopping/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3402bfbd9f5f5dc7b3a292be92ddac4ec0ccd351", @"/Views/_ViewImports.cshtml")]
    public class Views_Shopping_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Shopping\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
            BeginContext(46, 2372, true);
            WriteLiteral(@"



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
<!--Cart start-->
<section style=""padding-top:150px !important;overflow:hidden !important;"">
    <div class=""row heading-row justify-content-center pt-5 pb-5"">
        <h2 class=""section-title text-black"">
            SHOPPING LIST
        </h2>
    </div>
    <div class=""col-lg-12"">
        <table class=""table show-cart "" id=""GeneralCardList"">
            <tbody>
            </tbody>
    ");
            WriteLiteral(@"    </table>
        <div>Total price: $<span class=""total-cart""></span></div>
        <div class=""modal-footer top "">
            <button type=""button"" class=""btn btn-danger"">Go Back</button>
            <button type=""button"" class=""btn btn-success"">Order now</button>
        </div>
    </div>
</section>
<div class=""modal fade"" id=""cart"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
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
                <div>Total price: $<span class=""total-cart""></span>");
            WriteLiteral(@"</div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Order now</button>
            </div>
        </div>
    </div>
</div>
<!--Cart end-->
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
