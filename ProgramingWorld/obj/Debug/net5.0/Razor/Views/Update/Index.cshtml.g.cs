#pragma checksum "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d877c66661b8bf76494d527a28578532650f9db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Update_Index), @"mvc.1.0.view", @"/Views/Update/Index.cshtml")]
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
#line 1 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d877c66661b8bf76494d527a28578532650f9db", @"/Views/Update/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f636110b29e8081f02ad645baea9f57277755f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Update_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Update>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_SiteLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center style=\"margin-left:200px\">\r\n    <section class=\"section wb\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-9 col-md-12 col-sm-12 col-xs-12\">\r\n");
#nullable restore
#line 14 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
                     if (Model.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4 style=\"color: #1874cd\"><b>GÜNCELLEME NOTLARI</b></h4><br />\r\n                        <hr />\r\n");
#nullable restore
#line 18 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <b>Güncelleme Adı :</b> ");
#nullable restore
#line 20 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
                                               Write(item.UpdateName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b style=\"margin-left:240px\">Güncelleme Tarihi :</b> ");
#nullable restore
#line 20 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
                                                                                                                     Write(item.UpdateDateTime.ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                            <hr />\r\n                            <br />\r\n                            <b><u>Ekleme Ve Güncelleme Notları</u></b><br /><br />\r\n");
#nullable restore
#line 24 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
                       Write(Html.Raw(item.UpdateDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <br />\r\n                            <hr />\r\n");
#nullable restore
#line 27 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4 style=\"color: #1874cd\"><b>GÜNCELLEME NOTLARI BULUNAMADI...</b></h4>\r\n");
#nullable restore
#line 32 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Update\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</center>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Update>> Html { get; private set; }
    }
}
#pragma warning restore 1591
