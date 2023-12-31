#pragma checksum "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a42d098cf7654d0d7788db120c727bb8d21fb036"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a42d098cf7654d0d7788db120c727bb8d21fb036", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cbf4aca70d1bee513a04eb32707edd4413f3434", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-2"">
            <div class=""widget style1 red-bg"">
                <div class=""row vertical-align"">
                    <div class=""col-3"">
                        <i class=""fa fa-th-large fa-3x""></i>
                    </div>
                    <div class=""col-9 text-right"">
                        <span>Toplam Blog Sayısı</span>
                        <h2 class=""font-bold"">");
#nullable restore
#line 18 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.Blogs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-2"">
            <div class=""widget style1 lazur-bg"">
                <div class=""row vertical-align"">
                    <div class=""col-3"">
                        <i class=""fa fa-comments fa-3x""></i>
                    </div>
                    <div class=""col-9 text-right"">
                        <span>Toplam Yorum Sayısı</span>
                        <h2 class=""font-bold"">");
#nullable restore
#line 31 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.CommentAll);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-2"">
            <div class=""widget style1 yellow-bg"">
                <div class=""row vertical-align"">
                    <div class=""col-3"">
                        <i class=""fa fa-bars fa-3x""></i>
                    </div>
                    <div class=""col-9 text-right"">
                        <span>Kategori Sayısı</span>
                        <h2 class=""font-bold"">");
#nullable restore
#line 44 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-2"">
            <div class=""widget style1 red-bg"">
                <div class=""row vertical-align"">
                    <div class=""col-3"">
                        <i class=""fa fa-user fa-3x""></i>
                    </div>
                    <div class=""col-9 text-right"">
                        <span>Yazar Sayısı</span>
                        <h2 class=""font-bold"">");
#nullable restore
#line 57 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.Users);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-2"">
            <div class=""widget style1 lazur-bg"">
                <div class=""row vertical-align"">
                    <div class=""col-3"">
                        <i class=""fa fa-comments fa-3x""></i>
                    </div>
                    <div class=""col-9 text-right"">
                        <span>Toplam Yorum Sayısı</span>
                        <h2 class=""font-bold"">");
#nullable restore
#line 70 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.CommentAll);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-2"">
            <div class=""widget style1 yellow-bg"">
                <div class=""row vertical-align"">
                    <div class=""col-3"">
                        <i class=""fa fa-envelope fa-3x""></i>
                    </div>
                    <div class=""col-9 text-right"">
                        <span>Toplam Mesaj Sayısı</span>
                        <h2 class=""font-bold"">");
#nullable restore
#line 83 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.AllMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""widget-head-color-box navy-bg p-lg text-center"">
                <div class=""m-b-md"">
                    <h2 class=""font-bold no-margins"">
                        ");
#nullable restore
#line 94 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
                   Write(Model.FirstOrDefault().UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                </div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 3751, "\"", 3787, 1);
#nullable restore
#line 97 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 3757, Model.FirstOrDefault().IMGURL, 3757, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:150px;height:150px\" class=\"rounded-circle circle-border m-b-md\" alt=\"profile\">\r\n            </div>\r\n            <div class=\"widget-text-box\">\r\n                <h4 class=\"media-heading\">");
#nullable restore
#line 100 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
                                     Write(Model.FirstOrDefault().UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>");
#nullable restore
#line 101 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
              Write(Model.FirstOrDefault().About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"text-right\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4144, "\"", 4151, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-white\"><i class=\"fa fa-thumbs-up\"></i> Beğen </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4248, "\"", 4255, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-xs btn-primary""><i class=""fa fa-heart""></i> Kalp At</a>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-3"">
        <div class=""ibox"">
            <div class=""ibox-content"">
                <h5>Blog Durumu</h5>
                <h2>");
#nullable restore
#line 115 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(ViewBag.Blogs);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h2>\r\n                <div class=\"progress progress-xl\">\r\n                    <div");
            BeginWriteAttribute("style", " style=\"", 4680, "\"", 4711, 3);
            WriteAttributeValue("", 4688, "width:", 4688, 6, true);
#nullable restore
#line 117 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
WriteAttributeValue(" ", 4694, ViewBag.Blogs, 4695, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4709, "%;", 4709, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""progress-bar""></div>
                </div>

                <div class=""m-t-sm small"">Blog Durumu yenilendi.</div>
            </div>
        </div>
    </div>

    <div class=""col-lg-3"">
        <div class=""ibox"">
            <div class=""ibox-content"">
                <h5>Yorum Durumu</h5>
                <h2>");
#nullable restore
#line 129 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(ViewBag.CommentAll);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h2>\r\n                <div class=\"progress progress-xl\">\r\n                    <div");
            BeginWriteAttribute("style", " style=\"", 5148, "\"", 5183, 3);
            WriteAttributeValue("", 5156, "width:", 5156, 6, true);
#nullable restore
#line 131 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 5162, ViewBag.CommentAll, 5162, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5181, "%;", 5181, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""progress-bar""></div>
                </div>

                <div class=""m-t-sm small"">Yorum Durumu yenilendi.</div>
            </div>
        </div>
    </div>

    <div class=""col-lg-3"">
        <div class=""ibox"">
            <div class=""ibox-content"">
                <h5>Toplam Puan</h5>
                <h2>");
#nullable restore
#line 143 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(ViewBag.Puan);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h2>\r\n                <div class=\"progress progress-xl\">\r\n                    <div");
            BeginWriteAttribute("style", " style=\"", 5614, "\"", 5644, 3);
            WriteAttributeValue("", 5622, "width:", 5622, 6, true);
#nullable restore
#line 145 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
WriteAttributeValue(" ", 5628, ViewBag.Puan, 5629, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5642, "%;", 5642, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""progress-bar""></div>
                </div>

                <div class=""m-t-sm small"">Toplam Puan yenilendi.</div>
            </div>
        </div>
    </div>

    <div class=""col-lg-3"">
        <div class=""ibox"">
            <div class=""ibox-content"">
                <h5>Kategori Sayısı</h5>
                <h2>");
#nullable restore
#line 157 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
               Write(ViewBag.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h2>\r\n                <div class=\"progress progress-xl\">\r\n                    <div");
            BeginWriteAttribute("style", " style=\"", 6082, "\"", 6116, 3);
            WriteAttributeValue("", 6090, "width:", 6090, 6, true);
#nullable restore
#line 159 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Areas\Admin\Views\Dashboard\Index.cshtml"
WriteAttributeValue(" ", 6096, ViewBag.Category, 6097, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6114, "%;", 6114, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""progress-bar progress-bar-danger""></div>
                </div>

                <div class=""m-t-sm small"">Kategori Sayısı yenilendi.</div>
            </div>
        </div>
    </div>
</div>

<div class=""col-lg-12"">
    <div class=""ibox "">
        <div class=""ibox-title"">
            <h5>Sunucunun Durumu</h5>
        </div>
        <div class=""ibox-content"">

            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-line-chart-moving""></div>
            </div>
        </div>
    </div>
</div><br /><br /><br /><br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
