#pragma checksum "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e036f800d6e903a855a62288b2c67934290bbd9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_TestCoz), @"mvc.1.0.view", @"/Views/Test/TestCoz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e036f800d6e903a855a62288b2c67934290bbd9d", @"/Views/Test/TestCoz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae8aefa3c68973493840eb164c197d32d70fdff", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_TestCoz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Frontend.Models.SoruModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/testOlustur.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/testcoz.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("background", new global::Microsoft.AspNetCore.Html.HtmlString("/Images/bg2.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
  
    ViewData["Title"] = "TestCoz";
    Layout = "~/Views/Shared/_layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\" xmlns:th=\"http://www.thymeleaf.org\"/>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e036f800d6e903a855a62288b2c67934290bbd9d6410", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e036f800d6e903a855a62288b2c67934290bbd9d6672", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e036f800d6e903a855a62288b2c67934290bbd9d7850", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e036f800d6e903a855a62288b2c67934290bbd9d9732", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
      

        SoruModel s = new SoruModel();
        int a = 0;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"body2\">\r\n    <h1>");
#nullable restore
#line 20 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
   Write(ViewData["testAdi"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1><hr/>\r\n");
#nullable restore
#line 21 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
     using (Html.BeginForm("TestCoz", "Test", FormMethod.Post, s))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"tamsoru cardboyut cardarasibosluk\">\r\n                <div class=\"cardSoruDiv soru\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
               Write(Html.DisplayFor(x => item.soru, new {htmlAttributes = new {@class = "", id = "soru" + a + "-1"}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"row centerr\">\r\n                    <div");
                BeginWriteAttribute("id", " id=\"", 984, "\"", 999, 1);
#nullable restore
#line 31 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
WriteAttributeValue("", 989, "1" + a, 989, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"secenek cardsecenek1\" onClick=\"reply_click(this.id,)\">\r\n                        <a hidden> ");
#nullable restore
#line 32 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                              Write(Html.RadioButtonFor(x => x[a].dogruCevap, 1, new {htmlAttributes = new {GroupName = "radio" + a, @class = "form-control", id = "radiobuton1" + a}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 33 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                   Write(Html.DisplayFor(x => item.cevap1, new {htmlAttributes = new {@class = "form-control", id = "cevap" + a + "-1"}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div");
                BeginWriteAttribute("id", " id=\"", 1444, "\"", 1459, 1);
#nullable restore
#line 35 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
WriteAttributeValue("", 1449, "2" + a, 1449, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"secenek  cardsecenek2\" onClick=\"reply_click(this.id)\">\r\n                        <a hidden> ");
#nullable restore
#line 36 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                              Write(Html.RadioButtonFor(x => x[a].dogruCevap, 2, new {htmlAttributes = new {GroupName = "radio" + a, @class = "form-control", id = "radiobuton2" + a}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 37 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                   Write(Html.DisplayFor(x => item.cevap2, new {htmlAttributes = new {@class = "form-control", id = "cevap" + a + "-2"}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row centerr\">\r\n                    <div");
                BeginWriteAttribute("id", " id=\"", 1971, "\"", 1986, 1);
#nullable restore
#line 41 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
WriteAttributeValue("", 1976, "3" + a, 1976, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"secenek  cardsecenek3\" onClick=\"reply_click(this.id)\">\r\n                        <a hidden> ");
#nullable restore
#line 42 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                              Write(Html.RadioButtonFor(x => x[a].dogruCevap, 3, new {htmlAttributes = new {GroupName = "radio" + a, @class = "form-control", id = "radiobuton3" + a}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 43 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                   Write(Html.DisplayFor(x => item.cevap3, new {htmlAttributes = new {@class = "form-control", id = "cevap" + a + "-3"}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div");
                BeginWriteAttribute("id", " id=\"", 2431, "\"", 2446, 1);
#nullable restore
#line 45 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
WriteAttributeValue("", 2436, "4" + a, 2436, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"secenek  cardsecenek4\" onClick=\"reply_click(this.id)\">\r\n                        <a hidden> ");
#nullable restore
#line 46 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                              Write(Html.RadioButtonFor(x => x[a].dogruCevap, 4, new {htmlAttributes = new {GroupName = "radio" + a, @class = "form-control", id = "radiobuton4" + a}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 47 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                   Write(Html.DisplayFor(x => item.cevap4, new {htmlAttributes = new {@class = "form-control", id = "cevap" + a + "-4"}}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
       Write(Html.HiddenFor(s => s[a].testId, item.testId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
                                                          
            a++;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"center textcenter form-group\">\r\n            <input type=\"Submit\" , id=\"cozButon\" value=\"Kabul Et\" class=\" submit_btn \">\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n</div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e036f800d6e903a855a62288b2c67934290bbd9d17789", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e036f800d6e903a855a62288b2c67934290bbd9d18889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e036f800d6e903a855a62288b2c67934290bbd9d19989", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 62 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Test\TestCoz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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