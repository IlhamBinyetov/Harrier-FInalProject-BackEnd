#pragma checksum "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8a24bf0ad7b78097eb9aaf2fa0af1fefb64195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\_ViewImports.cshtml"
using HarrierFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\_ViewImports.cshtml"
using HarrierFinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\_ViewImports.cshtml"
using HarrierFinalProject.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\_ViewImports.cshtml"
using HarrierFinalProject.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8a24bf0ad7b78097eb9aaf2fa0af1fefb64195", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c47fea4d7d22529661737085a23daed142c8ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/contact-bg.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"bg\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff8a24bf0ad7b78097eb9aaf2fa0af1fefb641955666", async() => {
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
            WriteLiteral(@"
    <h2>CONTACT US</h2>
</section>

<section class=""map"">
    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2147.5636559089176!2d50.20617589285119!3d40.42848231172182!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40305dc1541db69f%3A0x41b9f6db3bce3231!2sGala%2C%20Dubandi%2C%20Azerbaijan!5e0!3m2!1sen!2s!4v1637404860459!5m2!1sen!2s""
            width=""600""
            height=""450""
            style=""border: 0""");
            BeginWriteAttribute("allowfullscreen", "\r\n            allowfullscreen=\"", 593, "\"", 624, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n            loading=\"lazy\"></iframe>\r\n</section>\r\n\r\n<section class=\"contact\">\r\n    <div class=\"contact-header\">\r\n        <h2>CONTACT US</h2>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8a24bf0ad7b78097eb9aaf2fa0af1fefb641957606", async() => {
                WriteLiteral("\r\n            <div class=\"d-flex justify-content-between mb-4\">\r\n                <div class=\"col-5\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 944, "\"", 950, 0);
                EndWriteAttribute();
                WriteLiteral(">Your Name(required)</label>\r\n                    <input type=\"text\" />\r\n                    <span></span>\r\n                </div>\r\n                <div class=\"col-5\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1146, "\"", 1152, 0);
                EndWriteAttribute();
                WriteLiteral(">Your Email(required)</label>\r\n                    <input type=\"email\" />\r\n                    <span></span>\r\n                </div>\r\n            </div>\r\n            <div class=\"subject mb-4\">\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 1369, "\"", 1375, 0);
                EndWriteAttribute();
                WriteLiteral(">Subject</label>\r\n                <input type=\"text\" />\r\n            </div>\r\n            <div class=\"message\">\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 1510, "\"", 1516, 0);
                EndWriteAttribute();
                WriteLiteral(">Your Message</label>\r\n                <br />\r\n                <textarea");
                BeginWriteAttribute("name", " name=\"", 1589, "\"", 1596, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1597, "\"", 1602, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n            </div>\r\n\r\n            <button type=\"submit\" class=\"submit\">Submit</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n<section class=\"features-section\">\r\n    <div class=\"features d-flex\">\r\n");
#nullable restore
#line 56 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\Contact\Index.cshtml"
         foreach (var item in Model.Advertisings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"feature-element col-3 d-flex justify-content-evenly\">\r\n                <div class=\"feature-icon\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff8a24bf0ad7b78097eb9aaf2fa0af1fefb6419511257", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2034, "~/assets/images/", 2034, 16, true);
#nullable restore
#line 60 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\Contact\Index.cshtml"
AddHtmlAttributeValue("", 2050, item.Logo, 2050, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <p class=\"feature-first-p\">");
#nullable restore
#line 63 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\Contact\Index.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"feature-second-p\">");
#nullable restore
#line 64 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\Contact\Index.cshtml"
                                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 67 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Views\Contact\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </div>\r\n</section>\r\n\r\n<section class=\"newsletter-section\">\r\n    <h5>NEWSLETTER</h5>\r\n    <h4>GET NOTIFIED OF ANY UPDATES!</h4>\r\n    <div class=\"form-elements\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8a24bf0ad7b78097eb9aaf2fa0af1fefb6419514120", async() => {
                WriteLiteral(@"
            <input type=""email""
                   name=""email""
                   placeholder=""Your email address""
                   id=""email"" />
            <button type=""submit"" class=""subs-btn"">
                <span><i class=""bi bi-envelope-fill envelope""></i></span>
                Subscribe
            </button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
