#pragma checksum "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26040f68d4d31033bbe1cc90b7368b5b9008cc81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Details), @"mvc.1.0.view", @"/Views/Admin/Details.cshtml")]
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
#line 1 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\_ViewImports.cshtml"
using WebSonHal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\_ViewImports.cshtml"
using WebSonHal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26040f68d4d31033bbe1cc90b7368b5b9008cc81", @"/Views/Admin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4581ba2db8b4204166e5ca0da6d510c26edcebd1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSonHal.Models.YaziYorum>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Details</h1>\n");
#nullable restore
#line 8 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
 foreach (var item in Model.Deger1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <h4>Yorum</h4>\n        <hr />\n        <dl class=\"row\">\n\n            \n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 17 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => item.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 20 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(model => item.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 23 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => item.Icerik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 26 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(model => item.Icerik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 29 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => item.Fotograf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 32 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(model => item.Fotograf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 35 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => item.OlusturulmaTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 38 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(model => item.OlusturulmaTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 41 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayNameFor(model => item.Kategori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 44 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
           Write(Html.DisplayFor(model => item.Kategori.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            \n        </dl>\n    </div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26040f68d4d31033bbe1cc90b7368b5b9008cc818640", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26040f68d4d31033bbe1cc90b7368b5b9008cc8110798", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\n</div>\n");
#nullable restore
#line 53 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\Admin\Details.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebSonHal.Models.YaziYorum> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
