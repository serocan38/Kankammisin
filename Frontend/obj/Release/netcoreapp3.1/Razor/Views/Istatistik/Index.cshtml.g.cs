#pragma checksum "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8228c6267c36e82a4839a0f8e92b647b94ea641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Istatistik_Index), @"mvc.1.0.view", @"/Views/Istatistik/Index.cshtml")]
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
#line 1 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\_ViewImports.cshtml"
using Frontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8228c6267c36e82a4839a0f8e92b647b94ea641", @"/Views/Istatistik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae8aefa3c68973493840eb164c197d32d70fdff", @"/Views/_ViewImports.cshtml")]
    public class Views_Istatistik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend.Models.IstatistikModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap-grid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Istatistik.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("background", new global::Microsoft.AspNetCore.Html.HtmlString("/Images/bg2.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AnasayfaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\" xmlns:th=\"http://www.thymeleaf.org\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8228c6267c36e82a4839a0f8e92b647b94ea6415640", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8228c6267c36e82a4839a0f8e92b647b94ea6415902", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8228c6267c36e82a4839a0f8e92b647b94ea6417080", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8228c6267c36e82a4839a0f8e92b647b94ea6418258", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css"" integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" type=""text/css"" href=""//cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""//cdn.datatables.net/fixedheader/3.1.6/css/fixedHeader.bootstrap4.min.css"" />

");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8228c6267c36e82a4839a0f8e92b647b94ea64110606", async() => {
                WriteLiteral(@"
<div class=""jumbotron body2"">
    <h1>İstatistikler</h1>
    <hr/>
    <table class=""table table-hover table-bordered"">
        <thead class=""thead-dark"">
            <tr>
                <th>Çözen</th>
                <th>Test Adı</th>
                <th>Doğru Sayısı</th>
                <th>Yanlış Sayısı</th>
                <th>Kankalık</th>
                <th style=""text-align: center"">İncele</th>

            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 35 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.cozen));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.testAdi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DogruSayisi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.YanlisSayisi));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Kankalik));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center\"");
                BeginWriteAttribute("onclick", "  onclick=\"", 2088, "\"", 2165, 5);
                WriteAttributeValue("", 2099, "location.href", 2099, 13, true);
                WriteAttributeValue(" ", 2112, "=", 2113, 2, true);
                WriteAttributeValue(" ", 2114, "\'", 2115, 2, true);
#nullable restore
#line 53 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
WriteAttributeValue("", 2116, Url.Action("CozulmusTest", "Istatistik",  item), 2116, 48, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2164, "\'", 2164, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <a class=\"fas fa-arrow-right\"></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
         if (Model.Count() ==0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr");
                BeginWriteAttribute("onclick", " onclick=\"", 2337, "\"", 2402, 5);
                WriteAttributeValue("", 2347, "location.href", 2347, 13, true);
                WriteAttributeValue(" ", 2360, "=", 2361, 2, true);
                WriteAttributeValue(" ", 2362, "\'", 2363, 2, true);
#nullable restore
#line 60 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"
WriteAttributeValue("", 2364, Url.Action("setTest", "TestOlustur"), 2364, 37, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2401, "\'", 2401, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <td COLSPAN=\"6\" class=\"text-center\">Hiç Testiniz Yok.Buraya Tıkla Hemen Test Oluştur</td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Istatistik\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral(@"
    <script type=""text/javascript"" src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"" src=""//cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""table"").dataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Turkish.json""
                },
                ""searching"": false,
                ""ordering"": true,
                ""paging"": true,
                ""pagingType"": ""full_numbers"",
                ""pageLength"": 10,
                ""responsive"": true,
                ""columnDefs"": [{
                    ""targets"": 4,
                    ""orderable"": false
                }, {
                    ""targets"": 5,
                    ""orderable"": false
                }]
            });
        });
    </script> 
");
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Frontend.Models.IstatistikModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591