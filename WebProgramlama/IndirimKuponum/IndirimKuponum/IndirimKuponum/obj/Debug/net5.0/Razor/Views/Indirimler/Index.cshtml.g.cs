#pragma checksum "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e61781035b65a08597c4665fab00ae3a94ed0628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Indirimler_Index), @"mvc.1.0.view", @"/Views/Indirimler/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e61781035b65a08597c4665fab00ae3a94ed0628", @"/Views/Indirimler/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8868f99843292e3ad4d008fa175f9d7a961e404", @"/Views/_ViewImports.cshtml")]
    public class Views_Indirimler_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IndirimKuponum.Models.Indirimler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>İndirim Listesi</h1>\r\n\r\n<hr />\r\n<p>\r\n    ");
#nullable restore
#line 12 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
Write(Html.ActionLink("Yeni İndirim Ekle", "Create", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<hr />\r\n\r\n\r\n<table class=\"table table-bordered table-hover table-striped\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Resim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.EklenmeTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 29 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Onay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Anasayfa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th style=\"width:170px;\"></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Resim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EklenmeTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 50 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
                 if (item.Onay)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label class=\"label label-success\">Onaylı</label>\r\n");
#nullable restore
#line 53 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label class=\"label label-danger\">Onay Bekliyor</label>\r\n");
#nullable restore
#line 57 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 60 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
                 if (item.Anasayfa)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label class=\"label label-success\">Anasayfa</label>\r\n");
#nullable restore
#line 63 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label class=\"label label-danger\">Anasayfa Değil</label>\r\n");
#nullable restore
#line 67 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }, new { @class = "btn btn-warning btn-xs" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 71 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { @class = "btn btn-danger btn-xs" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 74 "C:\Users\HP\Downloads\IndirimKuponum\IndirimKuponum\IndirimKuponum\Views\Indirimler\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IndirimKuponum.Models.Indirimler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
