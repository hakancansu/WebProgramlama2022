#pragma checksum "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d12f312a29af18dda6ee0f2e227866f36f832a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\_ViewImports.cshtml"
using WebSonHal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
using WebSonHal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d12f312a29af18dda6ee0f2e227866f36f832a7", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4581ba2db8b4204166e5ca0da6d510c26edcebd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Yazi>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Yazı Listesi</h1>\n\n<br />\n\n<table class=\"table table-bordered\">\n    <tr>\n        <th>ID</th>\n        <th>BAŞLIK</th>\n        <th>SİL</th>\n        <th>GÜNCELLE</th>\n        <th>Detaylar</th>\n    </tr>\n");
#nullable restore
#line 21 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 24 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
           Write(item.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 471, "\"", 500, 2);
            WriteAttributeValue("", 478, "/Admin/Delete/", 478, 14, true);
#nullable restore
#line 26 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
WriteAttributeValue("", 492, item.Id, 492, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">SİL</a></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 556, "\"", 583, 2);
            WriteAttributeValue("", 563, "/Admin/Edit/", 563, 12, true);
#nullable restore
#line 27 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
WriteAttributeValue("", 575, item.Id, 575, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">GÜNCELLE</a></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 645, "\"", 675, 2);
            WriteAttributeValue("", 652, "/Admin/Details/", 652, 15, true);
#nullable restore
#line 28 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
WriteAttributeValue("", 667, item.Id, 667, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">DETAYLAR</a></td>\n        </tr>\n");
#nullable restore
#line 30 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n<a href=\"/Admin/Create\" class=\"btn btn-primary\">Yeni Yazı</a>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Yazi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
