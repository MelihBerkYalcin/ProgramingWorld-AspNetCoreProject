#pragma checksum "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\SocialMediaFooter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae137cd76c4b3067c2d97206fdbdea9ff497ace"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialMediaFooter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SocialMediaFooter/Default.cshtml")]
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
#line 1 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\SocialMediaFooter\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae137cd76c4b3067c2d97206fdbdea9ff497ace", @"/Views/Shared/Components/SocialMediaFooter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f636110b29e8081f02ad645baea9f57277755f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SocialMediaFooter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\"", 60, "\"", 99, 1);
#nullable restore
#line 4 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\SocialMediaFooter\Default.cshtml"
WriteAttributeValue("", 67, Model.FirstOrDefault().Facebook, 67, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"Facebook\"><i class=\"fa fa-facebook\"></i></a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 202, "\"", 240, 1);
#nullable restore
#line 5 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\SocialMediaFooter\Default.cshtml"
WriteAttributeValue("", 209, Model.FirstOrDefault().Youtube, 209, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"Youtube\"><i class=\"fa fa-youtube\"></i></a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 341, "\"", 381, 1);
#nullable restore
#line 6 "C:\Users\Mümtaz\source\repos\ProgramingWorld\ProgramingWorld\Views\Shared\Components\SocialMediaFooter\Default.cshtml"
WriteAttributeValue("", 348, Model.FirstOrDefault().Instagram, 348, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"Instagram\"><i class=\"fa fa-instagram\"></i></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
