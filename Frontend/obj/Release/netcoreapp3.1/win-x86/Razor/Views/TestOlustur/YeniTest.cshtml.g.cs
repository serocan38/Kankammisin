#pragma checksum "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff0464514600bd7bcc2c20c4bdc8b352ce6cf7f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestOlustur_YeniTest), @"mvc.1.0.view", @"/Views/TestOlustur/YeniTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0464514600bd7bcc2c20c4bdc8b352ce6cf7f4", @"/Views/TestOlustur/YeniTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae8aefa3c68973493840eb164c197d32d70fdff", @"/Views/_ViewImports.cshtml")]
    public class Views_TestOlustur_YeniTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Frontend.Models.SoruModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cozulmusTest.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("background", new global::Microsoft.AspNetCore.Html.HtmlString("/Images/bg2.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
  
    ViewData["Title"] = "YeniTest";
    Layout = "_AnasayfaLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"tr\" xmlns:th=\"http://www.thymeleaf.org\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff0464514600bd7bcc2c20c4bdc8b352ce6cf7f46152", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff0464514600bd7bcc2c20c4bdc8b352ce6cf7f46414", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff0464514600bd7bcc2c20c4bdc8b352ce6cf7f47592", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff0464514600bd7bcc2c20c4bdc8b352ce6cf7f49474", async() => {
                WriteLiteral("\r\n    <div class=\"body2\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff0464514600bd7bcc2c20c4bdc8b352ce6cf7f49769", async() => {
                    WriteLiteral("\r\n            <div id=\"app\"");
                    BeginWriteAttribute("class", " class=\"", 486, "\"", 494, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n");
#nullable restore
#line 17 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                  
                    List<SoruModel> userModels = new List<SoruModel>();
                    int sayi = (int)ViewData["sayi"];
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                 for (var a = 0; a < sayi; a++)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <div id=\"tamSoru\" class=\"cardboyut cardarasibosluk\">\r\n                        <div class=\"cardSoruDiv soru\">\r\n                            ");
#nullable restore
#line 25 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                       Write(Html.LabelFor(x => x[a].soru, new { htmlAttributes = new { @class = "", id = "Soru" + a + "-1" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            ");
#nullable restore
#line 26 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                       Write(Html.TextBoxFor(x => x[a].soru, new { @class = "inputArkaplan", id = "soru" + a + "-1" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row center\">\r\n                            <div class=\"secenek  cardsecenek1 cevap\">\r\n                                ");
#nullable restore
#line 30 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.RadioButtonFor(x => x[a].dogruCevap, 1, new { htmlAttributes = new { GroupName = "radio" + a, @class = "form-control", id = "radiobuton" + a + "-1" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 31 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.LabelFor(x => x[a].cevap1, new { htmlAttributes = new { @class = "form-control", id = "cevaptext" + a + "-1" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                <a>");
#nullable restore
#line 32 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                              Write(Html.TextBoxFor(x => x[a].cevap1, new { @class = "form-control inputArkaplan", id = "cevap" + a + "-1" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n                            </div>\r\n                            <div class=\"secenek  cardsecenek2 cevap\">\r\n                                ");
#nullable restore
#line 35 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.RadioButtonFor(x => x[a].dogruCevap, 2, new { htmlAttributes = new { GroupName = "radio" + a, @class = "form-control", id = "radiobuton" + a + "-2" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 36 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.LabelFor(x => x[a].cevap2, new { htmlAttributes = new { @class = "form-control", id = "cevaptext" + a + "-2" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 37 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.TextBoxFor(x => x[a].cevap2, new { @class = "form-control inputArkaplan", id = "cevap" + a + "-2" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row center\">\r\n                            <div class=\"secenek  cardsecenek3 cevap\">\r\n                                ");
#nullable restore
#line 42 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.RadioButtonFor(x => x[a].dogruCevap, 3, new { htmlAttributes = new { GroupName = "radio" + a, @class = "form-control", id = "radiobuton" + a + "-3" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 43 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.LabelFor(x => x[a].cevap3, new { htmlAttributes = new { @class = "form-control", id = "cevaptext" + a + "-3" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 44 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.TextBoxFor(x => x[a].cevap3, new { @class = "form-control inputArkaplan", id = "cevap" + a + "-3" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </div>\r\n                            <div class=\"secenek  cardsecenek4 cevap\">\r\n                                ");
#nullable restore
#line 47 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.RadioButtonFor(x => x[a].dogruCevap, 4, new { htmlAttributes = new { GroupName = "radio" + a, @class = "form-control", id = "radiobuton" + a + "-4" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 48 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.LabelFor(x => x[a].cevap4, new { htmlAttributes = new { @class = "form-control", id = "cevaptext" + a + "-4" } }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                ");
#nullable restore
#line 49 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                           Write(Html.TextBoxFor(x => x[a].cevap4, new { @class = "form-control inputArkaplan", id = "cevap" + a + "-4" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                <div class=\"container\" style=\"margin-top: 3%\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\TestOlustur\YeniTest.cshtml"
               Write(Html.ValidationMessage("bos", new { @class = "hata row centerr" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    <div class=\"centerr row\">\r\n                        <input type=\"submit\" value=\"Test Oluştur\" class=\"submit_btn\" />\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Frontend.Models.SoruModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591