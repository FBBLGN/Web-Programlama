#pragma checksum "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd260d92740b6ec25d3b946657dab1895088d5f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Indirimler_ListArama), @"mvc.1.0.view", @"/Views/Indirimler/ListArama.cshtml")]
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
#line 1 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\_ViewImports.cshtml"
using IndirimKuponum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\_ViewImports.cshtml"
using IndirimKuponum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd260d92740b6ec25d3b946657dab1895088d5f9", @"/Views/Indirimler/ListArama.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8868f99843292e3ad4d008fa175f9d7a961e404", @"/Views/_ViewImports.cshtml")]
    public class Views_Indirimler_ListArama : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IndirimKuponum.Models.IndirimlerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
  
    ViewData["Title"] = "ListArama";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
Write(language.Getkey("IndirimListesi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
Write(Html.Partial("IndirimlerListesi", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("SagKolon", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
Write(Html.Partial("Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n<div class=\"well\">\r\n    <h4>");
#nullable restore
#line 20 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
   Write(language.Getkey("IndirimKategorileri"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-6\">\r\n            <ul class=\"list-unstyled\">\r\n                <li>\r\n                    <a href=\"/Indirimler/List/1\">");
#nullable restore
#line 25 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
                                            Write(language.Getkey("Giyim"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <ul class=\"list-unstyled\">\r\n                <li>\r\n                    <a href=\"/Indirimler/List/2\">");
#nullable restore
#line 32 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
                                            Write(language.Getkey("Seyahat"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <ul class=\"list-unstyled\">\r\n                <li>\r\n                    <a href=\"/Indirimler/List/3\">");
#nullable restore
#line 39 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
                                            Write(language.Getkey("Egelence"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <ul class=\"list-unstyled\">\r\n                <li>\r\n                    <a href=\"/Indirimler/List/4\">");
#nullable restore
#line 46 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
                                            Write(language.Getkey("Egitim"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <ul class=\"list-unstyled\">\r\n                <li>\r\n                    <a href=\"/Indirimler/List/5\">");
#nullable restore
#line 53 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
                                            Write(language.Getkey("Yemek"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <ul class=\"list-unstyled\">\r\n                <li>\r\n                    <a href=\"/Indirimler/List/6\">");
#nullable restore
#line 60 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\ListArama.cshtml"
                                            Write(language.Getkey("Aksesuar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LanguageServices language { get; private set; }
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
