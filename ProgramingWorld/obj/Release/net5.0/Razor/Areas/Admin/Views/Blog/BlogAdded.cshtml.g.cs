#pragma checksum "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7152c29311850dce936649f047d611a94089880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_BlogAdded), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/BlogAdded.cshtml")]
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
#line 1 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\_ViewImports.cshtml"
using ProgramingWorld.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\_ViewImports.cshtml"
using ProgramingWorld.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7152c29311850dce936649f047d611a94089880", @"/Areas/Admin/Views/Blog/BlogAdded.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cbf4aca70d1bee513a04eb32707edd4413f3434", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_BlogAdded : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Blog/Blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-white btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("BlogAdded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
  
    ViewData["Title"] = "BlogAdded";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"ibox \">\r\n            <div class=\"ibox-title\">\r\n                <h5>Blog Düzenle</h5>\r\n            </div>\r\n            <div class=\"ibox-content\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7152c29311850dce936649f047d611a940898806189", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group  row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Başlığı</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 18 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextBoxFor(I => I.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group  row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Anahtar Kelimeleri</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 22 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextBoxFor(I => I.BlogKeyword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Açıklaması</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 26 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextAreaFor(I => I.BlogContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Nasıl Yüklenir ?</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 30 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextAreaFor(I => I.BlogContentSetupDetails, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Sistematik Özellikler</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 34 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextAreaFor(I => I.BlogProgramingRequirement, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-sm-2 col-form-label"">Blog Resmi</label>
                        <div class=""col-sm-10""><input type=""file"" name=""formFile"" class=""file-upload-info"" value=""formFile"" style=""width:100%"" /><br /></div>
                    </div>
                    <div class=""form-group row"">
                        <label class=""col-sm-2 col-form-label"">Blog Kategorisi</label>
                        <div class=""col-sm-10"">");
#nullable restore
#line 42 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.DropDownListFor(I => I.CategoryID, (List<SelectListItem>)ViewBag.Liste, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Yazarı</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 46 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.DropDownListFor(I => I.AppUserId, (List<SelectListItem>)ViewBag.ListeUser, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <hr />\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Turbobit Linki</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 51 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextBoxFor(I => I.Turbobit, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Mediafire Linki</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 55 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextBoxFor(I => I.MediaFire, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog GoogleDriver Linki</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 59 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextBoxFor(I => I.GoogleDriver, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Mega Linki</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 63 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextBoxFor(I => I.Mega, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog BitLY Linki</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 67 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextBoxFor(I => I.BitLY, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Torrent Linki</label>\r\n                        <div class=\"col-sm-10\">");
#nullable restore
#line 71 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Blog\BlogAdded.cshtml"
                                          Write(Html.TextBoxFor(I => I.Torrent, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"hr-line-dashed\"></div>\r\n                    <div class=\"form-group row\">\r\n                        <div class=\"col-sm-4 col-sm-offset-2\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7152c29311850dce936649f047d611a9408988014595", async() => {
                    WriteLiteral("İptal Et");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <button class=\"btn btn-info btn-sm\" type=\"submit\">Oluştur</button>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
