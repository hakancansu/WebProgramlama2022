#pragma checksum "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf3df8f148eba0ee4fb71921e2c8f630c420b707"
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
#line 1 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\_ViewImports.cshtml"
using WebSonHal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\_ViewImports.cshtml"
using WebSonHal.Models;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3df8f148eba0ee4fb71921e2c8f630c420b707", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4581ba2db8b4204166e5ca0da6d510c26edcebd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebSonHal.Models.Yazi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Culture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
  
    
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf3df8f148eba0ee4fb71921e2c8f630c420b7074973", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf3df8f148eba0ee4fb71921e2c8f630c420b7076126", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 433, "\"", 443, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 469, "\"", 479, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\n    <!-- Bootstrap core CSS -->\n    <link href=\"vendor/bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\">\n\n    <!-- Custom styles for this template -->\n    <link href=\"css/blog-post.css\" rel=\"stylesheet\">\n\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf3df8f148eba0ee4fb71921e2c8f630c420b7077813", async() => {
                WriteLiteral("\n    <!-- Page Content -->\n  \n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-8\">\n");
#nullable restore
#line 34 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <!-- Post Content Column -->\n");
                WriteLiteral("                    <br />\n                    <!-- Preview Image -->\n                    <img class=\"img-fluid rounded\"");
                BeginWriteAttribute("src", " src=\"", 1056, "\"", 1076, 1);
#nullable restore
#line 40 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
WriteAttributeValue("", 1062, item.Fotograf, 1062, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1077, "\"", 1083, 0);
                EndWriteAttribute();
                WriteLiteral(">\n");
                WriteLiteral("                    <!-- Date/Time -->\n");
                WriteLiteral("                    <p align=\"right\">");
#nullable restore
#line 45 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
                                Write(localizer["Tarih"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
                                                    Write(item.OlusturulmaTarihi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
                WriteLiteral("                    <!-- Post Content -->\n                    <h2 class=\"mt-4\">");
#nullable restore
#line 48 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
                                Write(item.Baslik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n");
                WriteLiteral("                    <p>");
#nullable restore
#line 50 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
                  Write(item.Icerik);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n");
                WriteLiteral("                    <table class=\"table culture-table\">\n                        <tr>\n                            <a class=\"mt-4\"");
                BeginWriteAttribute("href", " href=\"", 1481, "\"", 1517, 2);
                WriteAttributeValue("", 1488, "/Home/YaziDetayIndex/", 1488, 21, true);
#nullable restore
#line 54 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
WriteAttributeValue("", 1509, item.Id, 1509, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"
                                                                            Write(localizer["Oku"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n                        </tr>\n                    </table>\n");
                WriteLiteral("                    <hr>\n");
#nullable restore
#line 60 "C:\Users\User\Documents\Bilgisayar Mühendisliği\4.SINIF\1.DÖNEM\WEB PROGRAMLAMA\WebProgramlama-BlogSitem-master\Site\WebSonHal\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>


        </div>
        <!-- /.row -->

    </div>
    <!-- /.container -->
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <!-- Footer -->
    <footer class=""py-5 bg-dark"">
        <div class=""container"">
            <p class=""m-0 text-center text-white"">Copyright &copy; Your Website 2022</p>
        </div>
        <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script>
        function SetCulture(selectedValue) {
            var culture = ""/?culture"" + selectedValue + ""&ui-culture-"" + selectedValue;
            alert(culture);
            document.getElementById(""cultureForm"").action = culture;
            document.getElementById(""cultureForm"").submit();
        }
    </script>

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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> Locoptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebSonHal.Models.Yazi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
