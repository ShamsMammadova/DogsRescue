#pragma checksum "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e485eeafc45f3adf6327bb3bc3320abb09dff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e485eeafc45f3adf6327bb3bc3320abb09dff1", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3402bfbd9f5f5dc7b3a292be92ddac4ec0ccd351", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Mission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(57, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(147, 817, true);
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
                        <li class=""breadcrumb-item active"">About us</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!--SubBanner end-->


<!-- About start -->
<section id=""video"">
    <div class=""container  pb-5"">
        <div class=""row align-items-center"">
            <div class=""col-md-6 mb-5 mb-md-0"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 964, "\"", 997, 1);
#line 37 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 971, Model.mainAbout.ImageLink, 971, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(998, 193, true);
            WriteLiteral(" class=\"popup-vimeo image-play\">\r\n                    <span class=\"icon-wrap\">\r\n                        <i class=\"fas fa-play-circle\"></i>\r\n                    </span>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1191, "\"", 1223, 2);
            WriteAttributeValue("", 1197, "img/", 1197, 4, true);
#line 41 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 1201, Model.mainAbout.Image, 1201, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1224, 225, true);
            WriteLiteral(" alt=\"\" class=\"img-fluid\">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-5 ml-auto\">\r\n                <h2 class=\"h2  mb-0\">Who we are</h2>\r\n                <p class=\"h5 mb-2\">\r\n                    ");
            EndContext();
            BeginContext(1450, 27, false);
#line 47 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
               Write(Model.aboutInfo.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1477, 22, true);
            WriteLiteral("\r\n                </p>");
            EndContext();
            BeginContext(1499, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56e485eeafc45f3adf6327bb3bc3320abb09dff17053", async() => {
                BeginContext(1546, 9, true);
                WriteLiteral("Read More");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1559, 378, true);
            WriteLiteral(@"

            </div>
        </div>
    </div>
</section>
<!-- About end-->


<!-- Team section start-->
<section id=""team"">
    <div class=""container pt-5 pb-5"">
        <div class=""team-title text-center"">
            <h3>Meet Our Volunteer</h3>
            <p>Our directory of real estate agents who can help you</p>
        </div>
        <div class=""row"">
");
            EndContext();
#line 65 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
             foreach (var item in Model.teams)
            {

#line default
#line hidden
            BeginContext(2000, 178, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-6\">\r\n                    <div class=\"team-member\">\r\n                        <div class=\"member-pic\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2178, "\"", 2199, 2);
            WriteAttributeValue("", 2184, "img/", 2184, 4, true);
#line 70 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 2188, item.Image, 2188, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2200, 462, true);
            WriteLiteral(@" alt="""">
                            <div class=""member-social"">
                                <a href=""""><i class=""fab fa-facebook-f""></i></a>
                                <a href=""""><i class=""fab fa-instagram""></i></a>
                                <a href=""""><i class=""fab fa-twitter""></i></a>

                            </div>
                        </div>
                        <div class=""member-info"">
                            <h5>");
            EndContext();
            BeginContext(2663, 9, false);
#line 79 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2672, 41, true);
            WriteLiteral("</h5>\r\n                            <span>");
            EndContext();
            BeginContext(2714, 9, false);
#line 80 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
                             Write(item.Info);

#line default
#line hidden
            EndContext();
            BeginContext(2723, 132, true);
            WriteLiteral("</span>\r\n                            <div class=\"member-contact\">\r\n                                <p><i class=\"fa fa-envelope\"></i>");
            EndContext();
            BeginContext(2856, 10, false);
#line 82 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
                                                            Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2866, 126, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 87 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3007, 549, true);
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- Team section end-->
<!-- Faqsection start-->
<section id=""fq"">
    <div class=""container-fluid bg-gray pt-3 pb-5"" id=""accordion-style-1"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""faq-title"">
                        <h2>Asked Questions</h2>
                    </div>
                </div>
                <div class=""col-12 mx-auto"">
                    <div class=""accordion"" id=""accordionExample"">
");
            EndContext();
#line 104 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
                         foreach (var item in Model.faqCollapses)
                        {

#line default
#line hidden
            BeginContext(3650, 104, true);
            WriteLiteral("                            <div class=\"card\">\r\n                                <div class=\"card-header\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3754, "\"", 3772, 1);
#line 107 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3759, item.Heading, 3759, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3773, 247, true);
            WriteLiteral(">\r\n                                    <h5 class=\"mb-0\">\r\n                                        <button class=\"btn btn-link btn-block text-left\" type=\"button\"\r\n                                                data-toggle=\"collapse\" data-target=\"#");
            EndContext();
            BeginContext(4021, 13, false);
#line 110 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
                                                                                Write(item.Collapse);

#line default
#line hidden
            EndContext();
            BeginContext(4034, 22, true);
            WriteLiteral("\" aria-expanded=\"true\"");
            EndContext();
            BeginWriteAttribute("aria-controls", "\r\n                                                aria-controls=\"", 4056, "\"", 4135, 1);
#line 111 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 4121, item.Collapse, 4121, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4136, 92, true);
            WriteLiteral(">\r\n                                            <i class=\"fa fa-angle-double-right mr-3\"></i>");
            EndContext();
            BeginContext(4229, 10, false);
#line 112 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
                                                                                    Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4239, 174, true);
            WriteLiteral("\r\n                                        </button>\r\n                                    </h5>\r\n                                </div>\r\n\r\n                                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4413, "\"", 4432, 1);
#line 117 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 4418, item.Collapse, 4418, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 4433, "\"", 4465, 3);
            WriteAttributeValue("", 4441, "collapse", 4441, 8, true);
#line 117 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
WriteAttributeValue(" ", 4449, item.Show, 4450, 10, false);

#line default
#line hidden
            WriteAttributeValue(" ", 4460, "fade", 4461, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 4466, "\"", 4497, 1);
#line 117 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 4484, item.Heading, 4484, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4498, 174, true);
            WriteLiteral("\r\n                                     data-parent=\"#accordionExample\">\r\n                                    <div class=\"card-body\">\r\n                                        ");
            EndContext();
            BeginContext(4673, 9, false);
#line 120 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
                                   Write(item.Desc);

#line default
#line hidden
            EndContext();
            BeginContext(4682, 122, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 124 "C:\Users\Shamsiye\source\repos\END PROJECT\GraduationProject\MyFinalProject\MyFinalProject\Views\About\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4831, 134, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Faqsection end-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591