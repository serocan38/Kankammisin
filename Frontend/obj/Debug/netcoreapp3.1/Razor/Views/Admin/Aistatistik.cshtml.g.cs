#pragma checksum "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf5b91f8faafb7e74881e253b31622a6c930a6fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Aistatistik), @"mvc.1.0.view", @"/Views/Admin/Aistatistik.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf5b91f8faafb7e74881e253b31622a6c930a6fb", @"/Views/Admin/Aistatistik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae8aefa3c68973493840eb164c197d32d70fdff", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Aistatistik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Frontend.Models.UserClaimModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
  
    ViewData["Title"] = "Aistatistik";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Aistatistik</h1>\r\n");
#nullable restore
#line 9 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
  
    string[] kturu = new String[]{"Admin","Kullanici"};
    List<string> a = new List<string>();
    a.Add("admin");
    a.Add("kullanici");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
 using (Html.BeginForm("Aistatistik", "Admin", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>UserModel</h4>\r\n    <hr/>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayNameFor(model => model.userModel.ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayFor(model => model.userModel.ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayNameFor(model => model.userModel.soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayFor(model => model.userModel.soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayNameFor(model => model.userModel.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayFor(model => model.userModel.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayNameFor(model => model.userModel.kullaniciAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayFor(model => model.userModel.kullaniciAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Kullanıcı Türü\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.DisplayFor(model => model.kullaniciTuru));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 52 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
       Write(Html.HiddenFor(m => m.userModel.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
             if (!Model.kullaniciTuru.Equals("Kullanici"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" value=\"Kullanici Yap\"/>\r\n");
#nullable restore
#line 56 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Admin yap\"/>\r\n");
#nullable restore
#line 60 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n    </dl>\r\n");
#nullable restore
#line 66 "C:\Users\serocan\source\repos\KankammisinBackend\Frontend\Views\Admin\Aistatistik.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Models.UserClaimModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
