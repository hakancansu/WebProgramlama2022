#pragma checksum "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "462f95e47cc6898a7db4b3f14dfb8bb245e8bb71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YaziDetay_Index), @"mvc.1.0.view", @"/Views/YaziDetay/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462f95e47cc6898a7db4b3f14dfb8bb245e8bb71", @"/Views/YaziDetay/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4581ba2db8b4204166e5ca0da6d510c26edcebd1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_YaziDetay_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebSonHal.Models.YaziYorum>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/blog-post.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/clean-blog.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/clean-blog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "462f95e47cc6898a7db4b3f14dfb8bb245e8bb716038", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 225, "\"", 235, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 261, "\"", 271, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\n\n    <!-- Bootstrap core CSS -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "462f95e47cc6898a7db4b3f14dfb8bb245e8bb716836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Custom styles for this template -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "462f95e47cc6898a7db4b3f14dfb8bb245e8bb718061", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "462f95e47cc6898a7db4b3f14dfb8bb245e8bb719238", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "462f95e47cc6898a7db4b3f14dfb8bb245e8bb7110415", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "462f95e47cc6898a7db4b3f14dfb8bb245e8bb7112296", async() => {
                WriteLiteral("\n    <br />\n    <!-- Page Content -->\n    <div class=\"container\">\n\n        <div class=\"row\">\n\n            <!-- Post Content Column -->\n            <div class=\"col-lg-12\">\n");
#nullable restore
#line 34 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                 foreach (var item in Model.Deger1)
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <!-- Preview Image -->\n                    <img class=\"img-fluid rounded\"");
                BeginWriteAttribute("src", " src=\"", 973, "\"", 993, 1);
#nullable restore
#line 38 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
WriteAttributeValue("", 979, item.Fotograf, 979, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 994, "\"", 1000, 0);
                EndWriteAttribute();
                WriteLiteral("> <!-- Date/Time -->\n                    <p align=\"right\">Posted on ");
#nullable restore
#line 39 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                                          Write(item.OlusturulmaTarihi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> <!-- Title -->\n                    <h2 class=\"mt-4\">");
#nullable restore
#line 40 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                                Write(item.Baslik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n");
                WriteLiteral("                    <hr> <!-- Post Content -->\n                    <p class=\"lead\">");
#nullable restore
#line 43 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                               Write(item.Icerik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                    <hr>\n");
#nullable restore
#line 45 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n            <div class=\"col-lg-8\">\n                <!-- Comments Form -->\n\n");
#nullable restore
#line 50 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                 foreach (var y in Model.Deger2)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("<!-- Single Comment -->\n                 <div class=\"media mb-4\">\n                     <img class=\"d-flex mr-3 rounded-circle\" src=\"http://placehold.it/50x50\"");
                BeginWriteAttribute("alt", " alt=\"", 1629, "\"", 1635, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                     <div class=\"media-body\">\n                          <h5 class=\"mt-0\">");
#nullable restore
#line 55 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                                      Write(y.Ad);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : </h5>\n                          ");
#nullable restore
#line 56 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                     Write(y.YorumIcerik);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                     </div>\n\n                  </div>\n");
#nullable restore
#line 60 "C:\Users\Faruk\Desktop\WebProgramlama2022-master - Kopya\Site\WebSonHal\Views\YaziDetay\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <br />\n                <br />\n                <br />\n");
                WriteLiteral(@"
            </div>




        </div>
        <!-- /.row -->

    </div>
    <!-- Footer -->
    <footer class=""py-5 bg-dark"">
        <div class=""container"">
            <p class=""m-0 text-center text-white"">Copyright &copy; Your Website 2020</p>
        </div>
        <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n");
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
