#pragma checksum "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Donate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcbbef84283d742c8ef6f9ae2491bfc2d3866e68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donate_Index), @"mvc.1.0.view", @"/Views/Donate/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Donate/Index.cshtml", typeof(AspNetCore.Views_Donate_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcbbef84283d742c8ef6f9ae2491bfc2d3866e68", @"/Views/Donate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3402bfbd9f5f5dc7b3a292be92ddac4ec0ccd351", @"/Views/_ViewImports.cshtml")]
    public class Views_Donate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Donate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Donatepartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(110, 958, true);
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
                        <li class=""breadcrumb-item active"">Donate</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!--SubBanner end-->


<!--  Donate start -->
<section id=""donate"">
    <div class=""container"">
        <div class=""row heading-row justify-content-center pt-5 "">
            <h2 class=""section-title text-black""style=""font-size:23px;"">
             THEY NEED YOU CARE & LOVE
            </h2>
        </div>
        <div id=""_Donatepartial"">
            ");
            EndContext();
            BeginContext(1068, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dcbbef84283d742c8ef6f9ae2491bfc2d3866e684907", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1101, 226, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row pt-3  pb-5\">\r\n            <button id=\"load_more\" class=\"btn btn-outline-success w-100 mx-auto my-5\">Load more</button>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n<!--  Donate end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Donate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
