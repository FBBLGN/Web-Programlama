#pragma checksum "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50433f412bdb63a5c88d0dceffa7480d4e80205a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kategori_Index), @"mvc.1.0.view", @"/Views/Kategori/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50433f412bdb63a5c88d0dceffa7480d4e80205a", @"/Views/Kategori/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8868f99843292e3ad4d008fa175f9d7a961e404", @"/Views/_ViewImports.cshtml")]
    public class Views_Kategori_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IndirimKuponum.Models.KategoriModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategori Listesi</h1>\r\n\r\n<hr />\r\n<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
Write(Html.ActionLink("Kategori Ekle", "Create", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<hr />\r\n\r\n\r\n<table class=\"table table-bordered table-hover table-striped\">\r\n    <tr>\r\n        <th style=\"width:60%;\">\r\n            ");
#nullable restore
#line 19 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.KategoriAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th style=\"width:17%;\">\r\n            ");
#nullable restore
#line 22 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.IndirimSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th style=\"width:100px;\"></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.KategoriAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IndirimSayisi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }, new { @class = "btn btn-warning btn-xs" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 38 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }, new { @class = "btn btn-primary btn-xs" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 39 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { @class = "btn btn-danger btn-xs" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Kategori\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IndirimKuponum.Models.KategoriModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
