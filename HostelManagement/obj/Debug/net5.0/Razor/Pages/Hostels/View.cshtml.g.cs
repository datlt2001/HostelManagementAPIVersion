#pragma checksum "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf67742e267821ed8c6055b13c5cf623454ddcec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HostelManagement.Pages.Hostels.Pages_Hostels_View), @"mvc.1.0.razor-page", @"/Pages/Hostels/View.cshtml")]
namespace HostelManagement.Pages.Hostels
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
#line 1 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\_ViewImports.cshtml"
using HostelManagement;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf67742e267821ed8c6055b13c5cf623454ddcec", @"/Pages/Hostels/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5141d99830df2e23e3f73eddd63a209ebd3f4b50", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Hostels_View : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Rents/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Accounts/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        <div class=""main-content col-12"">
            <div class=""hostel-content"">
                <div class=""hostel-header"">
                    <h2 class=""hostel-title"">");
#nullable restore
#line 12 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                        Write(Model.Hostel.HostelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <span class=\"hostel-cate\">");
#nullable restore
#line 13 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                         Write(Model.Hostel.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"hostel-location\"><a>");
#nullable restore
#line 15 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                           Write(Model.Hostel.Location.Ward.WardName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 15 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                                                 Write(Model.Hostel.Location.Ward.District.DistrictName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 15 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                                                                                                    Write(Model.Hostel.Location.Ward.District.Province.ProvinceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                <div class=\"hostel-images\">\r\n                    <div class=\"hostel-images-wrapper\">\r\n");
#nullable restore
#line 18 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                           
                                string imgClass="";
                                var imgs = Model.Hostel.HostelPics.Count-1;
                                if (imgs <= 1) {
                                    imgClass = "single-img"; 
                                }
                                else if (imgs < 3){
                                    imgClass = "few-img";
                                }
                                else imgClass = "multiple-img";
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1355, "\"", 1397, 3);
            WriteAttributeValue("", 1363, "hostel-imgs", 1363, 11, true);
            WriteAttributeValue(" ", 1374, "hostel-thumb", 1375, 13, true);
#nullable restore
#line 29 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
WriteAttributeValue(" ", 1387, imgClass, 1388, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 30 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                              
                                var hostelThumb = "placeholder.png";
                                if (Model.Hostel.HostelPics.Count>0){
                                    hostelThumb = "hostels/"+Model.Hostel.HostelPics.ElementAt(0).HostelPicUrl;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"img-wrapper\">\r\n                                <div class=\"img\"> \r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf67742e267821ed8c6055b13c5cf623454ddcec8375", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1906, "~/images/", 1906, 9, true);
#nullable restore
#line 38 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
AddHtmlAttributeValue("", 1915, hostelThumb, 1915, 12, false);

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
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                         if (Model.Hostel.HostelPics.Count>4){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"hostel-imgs\">\r\n                            <div class=\"imgs-wrapper\">\r\n");
#nullable restore
#line 45 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                 for (int i = 1; i < 5;i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 2315, "\"", 2341, 2);
            WriteAttributeValue("", 2323, "img-item", 2323, 8, true);
#nullable restore
#line 46 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
WriteAttributeValue(" ", 2331, imgClass, 2332, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"img-wrapper\"> \r\n                                        <div class=\"img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf67742e267821ed8c6055b13c5cf623454ddcec11415", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2522, "~/images/hostels/", 2522, 17, true);
#nullable restore
#line 49 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
AddHtmlAttributeValue("", 2539, Model.Hostel.HostelPics.ElementAt(i).HostelPicUrl, 2539, 50, false);

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
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 53 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 56 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>

                <div class=""hostel-content-nav"">

                </div>

                <div class=""hostel-content-overview"" id=""overview"">

                </div>

                <section class=""room-selection"" id=""room"">
                    <div class=""section-title"">Select your room</div>
");
#nullable restore
#line 70 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                     foreach (var item in Model.Rooms)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"hostel-room\">\r\n                        <div class=\"room-wrapper\">\r\n                            <div class=\"room-title\">\r\n                                <div class=\"room-title-left\">");
#nullable restore
#line 75 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                        Write(item.RoomTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                <div class=""room-title-right""></div>
                            </div>
                            <div class=""room-content"">
                                <div class=""room-content-wrapper"">
                                    <div class=""room-info"">
                                        <p></p>
                                        <div class=""room-photos-container"">
                                            <div class=""room-photo room-photo-thumb"">
");
#nullable restore
#line 84 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                  
                                                    string roomThumb ="placeholder.png";
                                                    if (item.RoomPics.Count >0)
                                                        {
                                                            roomThumb = "rooms/"+item.RoomPics.ElementAt(0).RoomPicUrl;
                                                        }
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf67742e267821ed8c6055b13c5cf623454ddcec16297", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4672, "~/images/", 4672, 9, true);
#nullable restore
#line 92 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
AddHtmlAttributeValue("", 4681, roomThumb, 4681, 10, false);

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
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 95 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                             if (item.RoomPics.Count>2){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"room-photo room-photo-others\">\r\n                                                    <div class=\"photo-small-wrapper\">\r\n");
#nullable restore
#line 98 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                         for (int i = 1; i < item.RoomPics.Count; i++){
                                                            var pic = item.RoomPics.ElementAt(i).RoomPicUrl;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""photo-item"">
                                                                <div class=""photo"">
                                                                    <div>
                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf67742e267821ed8c6055b13c5cf623454ddcec19221", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5606, "~/images/rooms/", 5606, 15, true);
#nullable restore
#line 103 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
AddHtmlAttributeValue("", 5621, pic, 5621, 4, false);

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
            WriteLiteral("\r\n                                                                    </div>\r\n                                                                </div>\r\n                                                            </div>\r\n");
#nullable restore
#line 107 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 110 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                        <div>
                                            <a class=""see-room-info"">Room photos and details</a>
                                            <div class=""room-description"">
                                                ");
#nullable restore
#line 115 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                           Write(item.RoomDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""room-booking-details"">
                                        <div class=""booking-details-inner"">
                                            <div class=""booking-details-header"">
                                                <div class=""header-item header-capacity p-2"">Capacity</div>
                                                <div class=""header-item header-price"">Price per month</div>
                                                <div class=""header-item header-book"">Book</div>
                                            </div>
                                            <div class=""booking-details"">
                                                <div class=""booking-details-contents"">
                                                    <div class=""booking-details-item details-capacity"">
            ");
            WriteLiteral("                                            <span>\r\n                                                            ");
#nullable restore
#line 130 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                       Write(item.RomMaxCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" adults
                                                            <i class='bx bx-male'></i>
                                                        </span>
                                                    </div>
                                                    <div class=""booking-details-item details-price"">
                                                        <div>
                                                            <span class=""currency"">
                                                                ₫
                                                            </span>
                                                            <span>");
#nullable restore
#line 139 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/month</span>
                                                        </div>
                                                    </div>
                                                    <div class=""booking-details-item details-book"">
                                                        <div class=""bookButton"">
                                                            <div>
                                                                <button class=""btn btn-primary"">
");
#nullable restore
#line 146 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                                     if (Model.UserRole == "Renter")
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf67742e267821ed8c6055b13c5cf623454ddcec25711", async() => {
                WriteLiteral("Rent Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                                                                        WriteLiteral(item.RoomId);

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
            WriteLiteral("\r\n");
#nullable restore
#line 149 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 151 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                                     if (String.IsNullOrEmpty(Model.UserRole))
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf67742e267821ed8c6055b13c5cf623454ddcec28713", async() => {
                WriteLiteral("Rent Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 154 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                    
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 168 "C:\Users\Admin\Documents\GitHub\HostelManagementAPIVersion\HostelManagement\Pages\Hostels\View.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </section>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HostelManagement.Pages.Hostels.ViewModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HostelManagement.Pages.Hostels.ViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HostelManagement.Pages.Hostels.ViewModel>)PageContext?.ViewData;
        public HostelManagement.Pages.Hostels.ViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
