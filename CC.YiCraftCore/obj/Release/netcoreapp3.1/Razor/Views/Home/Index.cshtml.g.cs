#pragma checksum "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae16b2872fdce0d8c2948820d6fb4cdc86093c4d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae16b2872fdce0d8c2948820d6fb4cdc86093c4d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9463d09279c255a14d438e8ae097aa36feb1065e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CC.YiCraftCore.Models.NoticeInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/白名单管理.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/图库.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/下载.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/关于我们.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"" style=""margin-top: 50px;"">
    <div class=""row"">
        <div class=""col-2  pt-0 text-center"">
            <div class=""col-12 shadow bg-white animated bounceInLeft mt-0 mb-4 img-thumbnail "">
                <a href=""/Question/Index"">白名单获取</a>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae16b2872fdce0d8c2948820d6fb4cdc86093c4d5371", async() => {
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-12 shadow bg-white animated bounceInLeft img-thumbnail my-4 \">\r\n                <a href=\"#\">历史图库</a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae16b2872fdce0d8c2948820d6fb4cdc86093c4d6660", async() => {
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-12 shadow bg-white animated bounceInLeft my-4 img-thumbnail\">\r\n                <a href=\"/Home/Download\">下载客户端</a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae16b2872fdce0d8c2948820d6fb4cdc86093c4d7962", async() => {
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-12 shadow bg-white animated bounceInLeft img-thumbnail  my-4 \">\r\n                <a href=\"#\">关于我们</a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae16b2872fdce0d8c2948820d6fb4cdc86093c4d9252", async() => {
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
            WriteLiteral(@"
            </div>
        </div>


        <div class=""col-10 shadow bg-white animated bounceInRight text-center "">
            <div class=""mt-5 delay-4s"">
            <h1 class=""animated fadeInDown""><span>YiCraftCore 意界核心</span></h1>
            <p class=""animated fadeInUp "">一个我的世界老牌服务器-开服时间长达：<em>8年</em></p>
                </div>



            <div class=""panel panel-default"">
                <!-- Default panel contents -->

                <div class=""panel-body"">
                    <p><h1>公告</h1></p>
                </div>
                <div class=""mb-2""> <a href=""/Home/add"" class=""btn btn-success"">发表公告</a></div>
                <!-- Table -->
                <table class=""table text-left"">
                    <thead>
                        <tr>
                            <th>编号</th>
                            <th>类型</th>
                            <th>公告标题</th>
                            <th>发布时间</th>
                            <th colspan=""3"" class=""text-center"">");
            WriteLiteral("操作</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
                          
                            List<NoticeInfo> noticeInfos = new List<NoticeInfo>();
                            noticeInfos = Model;
                            int i = 0;
                            noticeInfos.Reverse();
                            foreach (NoticeInfo u in noticeInfos)
                            {
                                i++;

                                if (u.Type == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 68 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th><label class=\"text-success\">公告</label></th>\r\n                                        <td>");
#nullable restore
#line 70 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
                                       Write(u.Tit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 71 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
                                       Write(u.SubTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td style=\"width: 85px;\" class=\"text-center\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3084, "\"", 3110, 2);
            WriteAttributeValue("", 3091, "/Home/Details/", 3091, 14, true);
#nullable restore
#line 73 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3105, u.ID, 3105, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">详情</a>\r\n                                        </td>\r\n                                        <td style=\"width: 85px;\" class=\"text-center\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3324, "\"", 3349, 2);
            WriteAttributeValue("", 3331, "/Home/update/", 3331, 13, true);
#nullable restore
#line 76 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3344, u.ID, 3344, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">修改</a>\r\n                                        </td>\r\n                                        <td style=\"width: 85px;\" class=\"text-center\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3563, "\"", 3585, 2);
            WriteAttributeValue("", 3570, "/Home/del/", 3570, 10, true);
#nullable restore
#line 79 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 3580, u.ID, 3580, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">删除</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"

                                }
                                else if (u.Type == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 87 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th><label class=\"text-primary\">活动</label></th>\r\n                                        <td>");
#nullable restore
#line 89 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
                                       Write(u.Tit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 90 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
                                       Write(u.SubTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td style=\"width: 85px;\" class=\"text-center\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4283, "\"", 4309, 2);
            WriteAttributeValue("", 4290, "/Home/Details/", 4290, 14, true);
#nullable restore
#line 92 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4304, u.ID, 4304, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">详情</a>\r\n                                        </td>\r\n                                        <td style=\"width: 85px;\" class=\"text-center\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4523, "\"", 4548, 2);
            WriteAttributeValue("", 4530, "/Home/update/", 4530, 13, true);
#nullable restore
#line 95 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4543, u.ID, 4543, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">修改</a>\r\n                                        </td>\r\n                                        <td style=\"width: 85px;\" class=\"text-center\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4762, "\"", 4784, 2);
            WriteAttributeValue("", 4769, "/Home/del/", 4769, 10, true);
#nullable restore
#line 98 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
WriteAttributeValue("", 4779, u.ID, 4779, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">删除</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 101 "C:\Users\FYZY\source\repos\CC.YiCraftCore\CC.YiCraftCore\Views\Home\Index.cshtml"
                                }


                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n       \r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CC.YiCraftCore.Models.NoticeInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
