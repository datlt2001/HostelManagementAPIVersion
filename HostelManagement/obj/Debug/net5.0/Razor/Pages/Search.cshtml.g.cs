#pragma checksum "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b4c169999215a2b7c84570a12c6a92ea9dfd9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HostelManagement.Pages.Pages_Search), @"mvc.1.0.razor-page", @"/Pages/Search.cshtml")]
namespace HostelManagement.Pages
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
#line 1 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\_ViewImports.cshtml"
using HostelManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b4c169999215a2b7c84570a12c6a92ea9dfd9f", @"/Pages/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5141d99830df2e23e3f73eddd63a209ebd3f4b50", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/placeholder.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Hostels/View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container main-container"" id=""main-content"">
    <div class=""row"">
        <div class=""col-3 sider sidebar"" id=""sider-navbar"">
            <div class=""sidebar__inner"">
                <div class=""sider-nav"">
                    <ul>
                        <li class=""sider-nav-item"">
                    </ul>
                </div>
            </div>
        </div>
        <div class=""col-9 main-content"">
            <div class=""hostel-list mt-3"">
                <div class=""hostel-list-wrapper"">
");
#nullable restore
#line 20 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                     foreach (var item in Model.Hostels) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"hostel-item mb-4\">\r\n                        <div class=\"hostel-item-inner d-flex\">\r\n                            <div class=\"hostel-dt hostel-images col p-0\">\r\n                                <div class=\"hostel-thumb\">\r\n");
#nullable restore
#line 25 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                     if (@item.HostelPics.Count>0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4b4c169999215a2b7c84570a12c6a92ea9dfd9f5510", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1026, "~/images/hostels/", 1026, 17, true);
#nullable restore
#line 26 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
AddHtmlAttributeValue("", 1043, item.HostelPics.ElementAt(0).HostelPicUrl, 1043, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                    }
                                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4b4c169999215a2b7c84570a12c6a92ea9dfd9f7414", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 32 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                 if (@item.HostelPics.Count > 4)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"hostel-imgs d-flex\">\r\n");
#nullable restore
#line 35 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                         for (int i = 1; i < item.HostelPics.Count; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"hostel-img\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b4b4c169999215a2b7c84570a12c6a92ea9dfd9f9598", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1779, "~/images/hostels/", 1779, 17, true);
#nullable restore
#line 38 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
AddHtmlAttributeValue("", 1796, item.HostelPics.ElementAt(i).HostelPicUrl, 1796, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n");
#nullable restore
#line 40 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n");
#nullable restore
#line 42 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"hostel-info col\">\r\n                                    <div class=\"hostel-name\">");
#nullable restore
#line 45 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                                        Write(item.HostelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"hostel-cate\">");
#nullable restore
#line 46 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                                        Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"hostel-location\"><a");
            BeginWriteAttribute("href", " href=\"", 2378, "\"", 2512, 5);
            WriteAttributeValue("", 2385, "https://www.google.com/maps/place/", 2385, 34, true);
#nullable restore
#line 47 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
WriteAttributeValue("", 2419, item.Location.Ward.District.Province.ProvinceName, 2419, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2469, ",", 2469, 1, true);
#nullable restore
#line 47 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
WriteAttributeValue("", 2470, item.Location.Ward.District.DistrictName, 2470, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2511, "/", 2511, 1, true);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"><i class=\'bx bxs-map\'></i> ");
#nullable restore
#line 47 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                                                                                                                                                                                                                                 Write(item.Location.Ward.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 47 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                                                                                                                                                                                                                                                                                     Write(item.Location.Ward.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></div>
                                </div>
                                <div class=""hostel-price col"">
                                    <div class=""col p-0""></div>
                                    <div class=""price col d-flex align-items-center justify-content-end""><span class=""currency"">???</span>");
#nullable restore
#line 51 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                                                                                                                   Write(item.Rooms.Where(r => r.RomMaxCapacity >= Model.capacityChoosen).Min(r => r.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("/month</div>\r\n                                    <div class=\"col d-flex align-items-end justify-content-end\">\r\n                                        <button class=\"btn btn-primary\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4b4c169999215a2b7c84570a12c6a92ea9dfd9f15467", async() => {
                WriteLiteral("Select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                                                                                                     WriteLiteral(item.HostelId);

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
            WriteLiteral("</button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 58 "D:\CN7\PRN221\Code\HostelManagement\HostelManagement\Pages\Search.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HostelManagement.Pages.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HostelManagement.Pages.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HostelManagement.Pages.SearchModel>)PageContext?.ViewData;
        public HostelManagement.Pages.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
