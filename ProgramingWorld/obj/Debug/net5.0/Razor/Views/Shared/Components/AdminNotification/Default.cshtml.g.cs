#pragma checksum "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b10c3c1389c673c32b432e7e1ac17dfc35919e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminNotification/Default.cshtml")]
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
#line 1 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b10c3c1389c673c32b432e7e1ac17dfc35919e94", @"/Views/Shared/Components/AdminNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f636110b29e8081f02ad645baea9f57277755f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"dropdown\">\r\n    <a class=\"dropdown-toggle count-info\" data-toggle=\"dropdown\" href=\"#\">\r\n        <i class=\"fa fa-bell\"></i>  <span class=\"label label-primary\">");
#nullable restore
#line 6 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
                                                                 Write(ViewBag.Notification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n    <ul class=\"dropdown-menu dropdown-alerts\">\r\n");
#nullable restore
#line 9 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
         foreach (var item in Model.Take(5))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a href=\"mailbox.html\" class=\"dropdown-item\">\r\n                <div>\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 490, "\"", 555, 3);
            WriteAttributeValue("", 498, "mdi", 498, 3, true);
#nullable restore
#line 14 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
WriteAttributeValue(" ", 501, item.NotificationTitleSymbol, 502, 29, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
WriteAttributeValue(" ", 531, item.NotificationColor, 532, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 14 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
                                                                                         Write(item.NotificationTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"float-right text-muted small\">");
#nullable restore
#line 15 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
                                                          Write(item.NotificationDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 15 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
                                                                                                       Write(item.NotificationDate.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </a>\r\n        </li>\r\n");
#nullable restore
#line 19 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\AdminNotification\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <li class=""dropdown-divider""></li>
        <li>
            <div class=""text-center link-block"">
                <a href=""notifications.html"" class=""dropdown-item"">
                    <strong>Bütün Bildirimleri Gör</strong>
                    <i class=""fa fa-angle-right""></i>
                </a>
            </div>
        </li>
    </ul>
</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
