#pragma checksum "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00578eb198daa4c59030d12888548a68e5124478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Indirimler_Details), @"mvc.1.0.view", @"/Views/Indirimler/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00578eb198daa4c59030d12888548a68e5124478", @"/Views/Indirimler/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8868f99843292e3ad4d008fa175f9d7a961e404", @"/Views/_ViewImports.cshtml")]
    public class Views_Indirimler_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndirimKuponum.Models.Indirimler>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 8 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\Details.cshtml"
Write(Model.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr />\r\n<p>\r\n    <span class=\"glyphicon glyphicon-time\"></span>\r\n    ");
#nullable restore
#line 12 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\Details.cshtml"
Write(Model.EklenmeTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<hr />\r\n<img class=\"img-responsive\" src=\"http://placehold.it/900x300\"");
            BeginWriteAttribute("alt", " alt=\"", 280, "\"", 286, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n<hr />\r\n<blockquote>\r\n    <p>");
#nullable restore
#line 18 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\Details.cshtml"
  Write(Model.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</blockquote>\r\n<p>\r\n    ");
#nullable restore
#line 21 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\Details.cshtml"
Write(Model.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<div class=\"comment\">\r\n    <hr />\r\n    <div class=\"well\">\r\n        <h4>Yorum Yap</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00578eb198daa4c59030d12888548a68e51244785714", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <textarea class=\"form-control\" rows=\"3\"></textarea>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <hr />
    <div class=""media"">
        <img class=""mr-3"" src=""..."" alt=""Generic placeholder image"">
        <div class=""media-body"">
            <h5 class=""mt-0"">Media heading</h5>
            Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
        </div>
    </div>
    <div class=""media"">
        <img class=""mr-3"" src=""..."" alt=""Generic placeholder image"">
        <div class=""media-body"">
            <h5 class=""mt-0"">Media heading</h5>
            Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
        </div>
    </div>
    <div class=""media"">
        <img class=""mr-3"" src=""");
            WriteLiteral(@"..."" alt=""Generic placeholder image"">
        <div class=""media-body"">
            <h5 class=""mt-0"">Media heading</h5>
            Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
        </div>
    </div>
</div>
<div>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00578eb198daa4c59030d12888548a68e51244788781", async() => {
                WriteLiteral("Listeye Dön");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("SagKolon", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 64 "C:\Users\HP\source\repos\IndirimKuponum\IndirimKuponum\Views\Indirimler\Details.cshtml"
Write(Html.Partial("Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndirimKuponum.Models.Indirimler> Html { get; private set; }
    }
}
#pragma warning restore 1591