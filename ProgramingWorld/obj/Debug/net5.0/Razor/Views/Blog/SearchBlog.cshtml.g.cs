#pragma checksum "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9411a0afbf5965d0bdccf9eec9e7e78865d50c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_SearchBlog), @"mvc.1.0.view", @"/Views/Blog/SearchBlog.cshtml")]
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
#line 1 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9411a0afbf5965d0bdccf9eec9e7e78865d50c0c", @"/Views/Blog/SearchBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f636110b29e8081f02ad645baea9f57277755f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_SearchBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
  
    ViewData["Title"] = "SearchBlog";
    Layout = "~/Views/Shared/_SiteLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""section wb"">
        <div class=""container"">
            <h4 style=""color: #1874cd""><b>Aradığınız Kelimeye Ait Bloglar</b></h4>
            <div class=""row"">
                <div class=""col-lg-9 col-md-12 col-sm-12 col-xs-12"">
                    <hr />
");
#nullable restore
#line 19 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""page-wrapper"">
                            <div class=""blog-list clearfix"">
                                <div class=""blog-box row"">
                                    <div class=""col-md-4"">
                                        <div class=""post-media"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9411a0afbf5965d0bdccf9eec9e7e78865d50c0c5528", async() => {
                WriteLiteral("\r\n                                                <img");
                BeginWriteAttribute("src", " src=\"", 1066, "\"", 1088, 1);
#nullable restore
#line 27 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
WriteAttributeValue("", 1072, item.BlogIMGURL, 1072, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1089, "\"", 1095, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\" style=\"width:600px; height:270px;\">\r\n                                                <div class=\"hovereffect\"></div>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 936, "~/Blog/BlogDetails/", 936, 19, true);
#nullable restore
#line 26 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
AddHtmlAttributeValue("", 955, item.BlogID, 955, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 967, "/", 967, 1, true);
#nullable restore
#line 26 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
AddHtmlAttributeValue("", 968, Url.AdresDuzenle(item.BlogTitle), 968, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"blog-meta big-meta col-md-8\">\r\n                                        <span class=\"bg-aqua\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9411a0afbf5965d0bdccf9eec9e7e78865d50c0c8458", async() => {
#nullable restore
#line 33 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                                                                                                                                                                      Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1525, "~/Blog/BlogCategoryGetList/", 1525, 27, true);
#nullable restore
#line 33 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
AddHtmlAttributeValue("", 1552, item.CategoryID, 1552, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1568, "/", 1568, 1, true);
#nullable restore
#line 33 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
AddHtmlAttributeValue("", 1569, Url.AdresDuzenle(item.Category.CategoryName), 1569, 45, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n                                        <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9411a0afbf5965d0bdccf9eec9e7e78865d50c0c10817", async() => {
#nullable restore
#line 34 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                                                                                                                            Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1718, "~/Blog/BlogDetails/", 1718, 19, true);
#nullable restore
#line 34 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
AddHtmlAttributeValue("", 1737, item.BlogID, 1737, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1749, "/", 1749, 1, true);
#nullable restore
#line 34 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
AddHtmlAttributeValue("", 1750, Url.AdresDuzenle(item.BlogTitle), 1750, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                                        <p>");
#nullable restore
#line 35 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                                      Write(Html.Raw(@item.BlogContent.Substring(0, item.BlogContent.Substring(0, 240).LastIndexOf(" "))));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</p>\r\n                                        <small style=\"color: #1874cd\">");
#nullable restore
#line 36 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                                                                 Write(item.BlogCreateDate.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                        <small>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9411a0afbf5965d0bdccf9eec9e7e78865d50c0c13902", async() => {
#nullable restore
#line 37 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                                                                                                                                           Write(item.AppUser.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2147, "~/Blog/WriterBlogGet/", 2147, 21, true);
#nullable restore
#line 37 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
AddHtmlAttributeValue("", 2168, item.AppUserId, 2168, 15, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2183, "/", 2183, 1, true);
#nullable restore
#line 37 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
AddHtmlAttributeValue("", 2184, Url.AdresDuzenle(item.AppUser.UserName), 2184, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</small>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <hr class=\"invis\">\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
#nullable restore
#line 45 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <hr class=\"invis\">\r\n\r\n                    ");
#nullable restore
#line 49 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
               Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("SearchBlog", new { page }),
              new PagedListRenderOptions
              {
                  DisplayLinkToIndividualPages = true,
                  DisplayPageCountAndCurrentLocation = false,
                  LiElementClasses = new string[] { "page-item" },
                  PageClasses = new string[] { "page-link" },
              }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"col-lg-3 col-md-12 col-sm-12 col-xs-12\">\r\n                    <div class=\"sidebar\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftSearchLayout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 62 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftCategoryLayout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 63 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftMaximumPuan3Subject"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 64 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftSocialMedia"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 65 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftReklam"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 71 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""section wb"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9 col-md-12 col-sm-12 col-xs-12"">
                    <h3>Aradığınız Kelimeye Ait Sonuç Bulunamadı....</h3>
                    <hr class=""invis"">

                </div>
                <div class=""col-lg-3 col-md-12 col-sm-12 col-xs-12"">
                    <div class=""sidebar"">
                        ");
#nullable restore
#line 84 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftSearchLayout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 85 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftCategoryLayout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 86 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftMaximumPuan3Subject"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 87 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftSocialMedia"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 88 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
                   Write(await Component.InvokeAsync("LeftReklam"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 94 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Blog\SearchBlog.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
