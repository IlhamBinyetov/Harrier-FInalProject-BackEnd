#pragma checksum "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f1afd0f51d748e91e544cbb8a63784ac64ebb73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\_ViewImports.cshtml"
using HarrierFinalProject.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\_ViewImports.cshtml"
using HarrierFinalProject.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\_ViewImports.cshtml"
using HarrierFinalProject.Data.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f1afd0f51d748e91e544cbb8a63784ac64ebb73", @"/Areas/Manage/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a274e9240ef55a57b54d7f94d89b863944a79e67", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletefetch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-item-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:14px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int order = 0;
   //var member = userManager.GetUserAsync(User).Result;
    
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""width:100%;"">
    <div class=""d-flex justify-content-between align-items-center pt-5"">
        <div class=""col-6"">
            <h1>Contact Messages</h1>

        </div>

    </div>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"" style=""font-size:14px"">#</th>
                <th scope=""col"" style=""font-size:14px""> User Name</th>
                <th scope=""col"" style=""font-size:14px""> User Email</th>
                <th scope=""col"" style=""font-size:14px"">Subject</th>
                <th scope=""col"" style=""font-size:14px"">Message</th>
                

                <th scope=""col"" style=""font-size:14px"">Actions</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
             foreach (var contact in Model.Contacts)
            {
                order++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 38 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
                           Write(order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n               \r\n                <td>");
#nullable restore
#line 40 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
               Write(contact.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"font-size:14px\">");
#nullable restore
#line 41 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
                                      Write(contact.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"font-size:14px\">");
#nullable restore
#line 42 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
                                      Write(contact.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"font-size:14px\"><textarea class=\"p-3\">");
#nullable restore
#line 43 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
                                                            Write(contact.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea> </td>\r\n             \r\n                <td>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f1afd0f51d748e91e544cbb8a63784ac64ebb738253", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
                                                  WriteLiteral(contact.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\binye\Desktop\Harrier-FinalProject-BackEnd\HarrierFinalProject\HarrierFinalProject\Areas\Manage\Views\Contact\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
