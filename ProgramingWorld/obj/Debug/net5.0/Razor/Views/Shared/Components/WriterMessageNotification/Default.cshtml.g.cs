#pragma checksum "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ed124e5712a1a1178458da51ea8c2956e38b61a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterMessageNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
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
#line 1 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\_ViewImports.cshtml"
using ProgramingWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\_ViewImports.cshtml"
using ProgramingWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed124e5712a1a1178458da51ea8c2956e38b61a", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f636110b29e8081f02ad645baea9f57277755f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterMessageNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item preview-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Writer/WriterInBox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<li class=""nav-item dropdown"">
    <a class=""nav-link count-indicator dropdown-toggle"" id=""messageDropdown"" href=""#"" data-toggle=""dropdown"" aria-expanded=""false"">
        <i class=""mdi mdi-email-outline""></i>
        <span class=""count-symbol bg-warning""></span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""messageDropdown"">
        <h6 class=""p-3 mb-0"">Mesajlar</h6>
        <div class=""dropdown-divider""></div>
");
#nullable restore
#line 12 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
         foreach (var item in Model.Take(3))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ed124e5712a1a1178458da51ea8c2956e38b61a5102", async() => {
                WriteLiteral("\r\n                <div class=\"preview-thumbnail\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 765, "\"", 794, 1);
#nullable restore
#line 16 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
WriteAttributeValue("", 771, item.SenderUser.IMGURL, 771, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"image\" class=\"profile-pic\">\r\n                </div>\r\n                <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                    <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
#nullable restore
#line 19 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                                                            Write(item.SenderUser);

#line default
#line hidden
#nullable disable
                WriteLiteral(" sana bir mesaj gönderdi.</h6>\r\n                    <p class=\"text-gray mb-0\"> ");
#nullable restore
#line 20 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                          Write(item.MessageDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 20 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                                                                      Write(item.MessageDate.ToShortTimeString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 649, "~/Writer/MessageDetails/", 649, 24, true);
#nullable restore
#line 14 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
AddHtmlAttributeValue("", 673, item.MessageID, 673, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ed124e5712a1a1178458da51ea8c2956e38b61a9030", async() => {
                WriteLiteral("<h6 class=\"p-3 mb-0 text-center\">Bütün Mesajları Gör</h6>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
