#pragma checksum "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4288985c9443aad553d51c5c62ed93a23dbb3fc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\_ViewImports.cshtml"
using IndirimKuponum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\_ViewImports.cshtml"
using IndirimKuponum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4288985c9443aad553d51c5c62ed93a23dbb3fc0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8868f99843292e3ad4d008fa175f9d7a961e404", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IndirimKuponum.Models.IndirimlerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>İndirim Listesi</h2>\r\n\r\n\r\n\r\n    ");
#nullable restore
#line 11 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Home\Index.cshtml"
Write(Html.Partial("IndirimlerListesi", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("SagKolon", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Home\Index.cshtml"
Write(Html.Partial("Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<div class=""well"">
    <h4>İndirim Kategorileri</h4>
    <div class=""row"">
        <div class=""col-lg-6"">
            <ul class=""list-unstyled"">
                <li>
                    <a href=""/Indirimler/List/1"">Giyim</a>
                </li>
            </ul>
        </div>
        <div class=""col-lg-6"">
            <ul class=""list-unstyled"">
                <li>
                    <a href=""/Indirimler/List/2"">Seyehat</a>
                </li>
            </ul>
        </div>
        <div class=""col-lg-6"">
            <ul class=""list-unstyled"">
                <li>
                    <a href=""/Indirimler/List/3"">Eğlence</a>
                </li>
            </ul>
        </div>
        <div class=""col-lg-6"">
            <ul class=""list-unstyled"">
                <li>
                    <a href=""/Indirimler/List/4"">Eğitim</a>
                </li>
            </ul>
        </div>
        <div class=""col-lg-6"">
            <ul class=""list-unstyled"">
                <");
                WriteLiteral(@"li>
                    <a href=""/Indirimler/List/5"">Yemek</a>
                </li>
            </ul>
        </div>
        <div class=""col-lg-6"">
            <ul class=""list-unstyled"">
                <li>
                    <a href=""/Indirimler/List/6"">Aksesuar</a>
                </li>
            </ul>
        </div>
    </div>
</div>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IndirimKuponum.Models.IndirimlerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
