#pragma checksum "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad99a53148fb7784cf9cfa7851e533bd4510b2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Indirimler_List), @"mvc.1.0.view", @"/Views/Indirimler/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad99a53148fb7784cf9cfa7851e533bd4510b2a", @"/Views/Indirimler/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8868f99843292e3ad4d008fa175f9d7a961e404", @"/Views/_ViewImports.cshtml")]
    public class Views_Indirimler_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IndirimKuponum.Models.IndirimlerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>İndirim Listesi</h2>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\"><h3>Kayıt Bulunamadı</h3></div>\r\n");
#nullable restore
#line 15 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
Write(Html.Partial("IndirimlerListesi", Model));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
                                             
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SagKolon", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
Write(Html.Partial("Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <div class=\"well\">\r\n        <h4>İndirim Kategorileri</h4>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 655, "\"", 687, 2);
                WriteAttributeValue("", 662, "/Indirimler/List/", 662, 17, true);
#nullable restore
#line 34 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
WriteAttributeValue("", 679, item.Id, 679, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
                                                           Write(item.KategoriId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\List.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
