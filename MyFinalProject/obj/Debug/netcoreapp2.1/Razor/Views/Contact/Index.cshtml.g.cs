#pragma checksum "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc2861bab707d8b030bd4c7c9c00aa459f2da15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Index.cshtml", typeof(AspNetCore.Views_Contact_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc2861bab707d8b030bd4c7c9c00aa459f2da15", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3402bfbd9f5f5dc7b3a292be92ddac4ec0ccd351", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(59, 1146, true);
            WriteLiteral(@"


<!--SubBanner start-->
    <section id=""sub-banner"" style=""background-image: url('../img/paw.jpg')"">
        <div class=""all-title-box"">
            <div class=""container "">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <h2>ABOUT US</h2>
                        <ul class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"">Contact Us</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
<!--SubBanner end-->

<!-- Contact Section Begin -->
<section class=""contact-section"">
    <div class=""container"">
        <div class=""row pt-5"">
            <div class=""col-lg-5"">
                <div class=""contact-title"">
                    <h4>Contact Us</h4>
                    <p>
                        Contrary to popular belief, Lorem Ipsu");
            WriteLiteral("m is simply random text.\r\n                    </p>\r\n                </div>\r\n                <div class=\"contact-widget\">\r\n");
            EndContext();
#line 38 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Contact\Index.cshtml"
                     foreach (var item in Model.contactAdresses)
                    {

#line default
#line hidden
            BeginContext(1294, 132, true);
            WriteLiteral("                        <div class=\"cw-item\">\r\n                            <div class=\"ci-icon\">\r\n                                <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1426, "\"", 1444, 1);
#line 42 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1434, item.Icon, 1434, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1445, 132, true);
            WriteLiteral("></i>\r\n                            </div>\r\n                            <div class=\"ci-text\">\r\n                                <span>");
            EndContext();
            BeginContext(1578, 10, false);
#line 45 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Contact\Index.cshtml"
                                 Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1588, 45, true);
            WriteLiteral(":</span>\r\n                                <p>");
            EndContext();
            BeginContext(1634, 9, false);
#line 46 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Contact\Index.cshtml"
                              Write(item.Desc);

#line default
#line hidden
            EndContext();
            BeginContext(1643, 74, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 49 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\Contact\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1740, 352, true);
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-lg-6 offset-lg-1"">
                <div class=""contact-form"">
                    <div class=""leave-comment"">
                        <h4>Leave Your Message</h4>
                        <p>Our staff will call back later and answer your questions.</p>
                        ");
            EndContext();
            BeginContext(2092, 1131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cc2861bab707d8b030bd4c7c9c00aa459f2da157970", async() => {
                BeginContext(2112, 1104, true);
                WriteLiteral(@"
                            <div class=""form-group mb-3 position-relative"">
                                <label for="""">Your Name</label>
                                <input type=""text"" placeholder=""Type your name"" class=""form-control sign-in-input px-3"">
                                <span class=""line""></span>
                            </div>
                            <div class=""form-group position-relative"">
                                <label for="""">Email</label>
                                <input type=""email"" placeholder=""Type your email"" class=""form-control sign-in-input px-3"">
                                <span class=""line""></span>
                            </div>
                            <div class=""form-group position-relative"">
                                <label for="""">Your Message</label>
                                <textarea name="""" id="""" cols=""30"" rows=""10"" class=""form-control sign-in-input px-3""></textarea>
                                <span cl");
                WriteLiteral("ass=\"line\"></span>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3223, 614, true);
            WriteLiteral(@"
                        <input type=""submit"" value=""Send"" class=""mt-4"">
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Contact Section End -->

<!-- Map Section Begin -->
<div class=""map"">
    <div class=""map-inner"">
        <iframe src=""https://maps.google.com/maps?q=baku&t=&z=13&ie=UTF8&iwloc=&output=embed"" height=""610""
                style=""border:0"" allowfullscreen="""">
        </iframe>
        <div class=""icon"">
            <i class=""fa fa-map-marker""></i>
        </div>
    </div>
</div>
<!-- Map Section Begin -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
