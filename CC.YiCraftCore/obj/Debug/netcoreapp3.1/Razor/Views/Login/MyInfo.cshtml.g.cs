#pragma checksum "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Login\MyInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f61e8356154088ac1aaeff7a637da5c8e9167f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_MyInfo), @"mvc.1.0.view", @"/Views/Login/MyInfo.cshtml")]
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
#line 1 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\_ViewImports.cshtml"
using CC.YiCraftCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\_ViewImports.cshtml"
using CC.YiCraftCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f61e8356154088ac1aaeff7a637da5c8e9167f0", @"/Views/Login/MyInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9463d09279c255a14d438e8ae097aa36feb1065e", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_MyInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CC.YiCraftCore.Models.UserInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Login\MyInfo.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""bg-success shadow mb-4"" style=""height: 300px;""></div>
<div class=""container mb-4"">
    <div class=""row"">
        <div class=""col-sm-2 col-xs-12 shadow bg-white shadow"" style=""background-color: white;"">
            <button class=""btn btn-outline-success col-12"">个人资料</button>
            <button class=""btn btn-outline-success col-12"">个人资料</button>
            <button class=""btn btn-outline-success col-12"">个人资料</button>
            <button class=""btn btn-outline-success col-12"">个人资料</button>
            <button class=""btn btn-outline-success col-12"">个人资料</button>
            <button class=""btn btn-outline-success col-12"">个人资料</button>
            <button class=""btn btn-outline-success col-12"">个人资料</button>
            <button class=""btn btn-outline-success col-12"">个人资料</button>
        </div>
        <div class=""ml-sm-4 col-sm-9 ml-xs-0 col-xs-12  bg-white shadow"" style=""height: 800px;background-color: white;"">
            <div>
                <div class=""row mt-4"">
               ");
            WriteLiteral(@"     <label class=""col-6"">
                        账号信息
                    </label>
                    <div class=""col-6 text-right"">
                        <button class=""btn btn-warning"">修改</button>
                    </div>

                </div>
                <hr>
                <table class=""table"" style=""width :300px;"">
                    <tr>
                        <td>ID</td>
                        <td>");
#nullable restore
#line 34 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Login\MyInfo.cshtml"
                       Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>用户名</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Login\MyInfo.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>简介</td>\r\n                        <td>暂未开放</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>等级</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Login\MyInfo.cshtml"
                       Write(Model.LV);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </table>
                <hr>
            </div>

            <div>
                <div class=""row mt-4"">
                    <label class=""col-6"">
                        账号信息
                    </label>
                    <div class=""col-6 text-right"">
                        <button class=""btn btn-warning"">修改</button>
                    </div>

                </div>
                <hr>
                <table class=""table"" style=""width :300px;"">
                    <tr>
                        <td>ID</td>
                        <td>");
#nullable restore
#line 66 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Login\MyInfo.cshtml"
                       Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>用户名</td>\r\n                        <td>");
#nullable restore
#line 70 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Login\MyInfo.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>简介</td>\r\n                        <td>暂未开放</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>等级</td>\r\n                        <td>");
#nullable restore
#line 78 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Login\MyInfo.cshtml"
                       Write(Model.LV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n                <hr>\r\n            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CC.YiCraftCore.Models.UserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591