#pragma checksum "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e915500582f028e95b48cf49196c626875238147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_GetConversation), @"mvc.1.0.view", @"/Views/Messages/GetConversation.cshtml")]
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
#line 1 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\_ViewImports.cshtml"
using ApartmentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\_ViewImports.cshtml"
using ApartmentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e915500582f028e95b48cf49196c626875238147", @"/Views/Messages/GetConversation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d008b0b4f5a0db9479da938df8eb7804bafcc95d", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_GetConversation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApartmentManagement.Domain.Entities.Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml"
  
    ViewData["Title"] = "GetConversation";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   <link rel=""stylesheet"" href=""chat.css"">
<div class=""page-content page-container"" id=""page-content"">
    <div class=""padding"">
        <div class=""row container d-flex justify-content-center"">
            <div class=""col-md-6"">
                <div class=""card card-bordered"">
                    <div class=""card-header"">

                    </div>
                    <div class=""ps-container ps-theme-default ps-active-y"" id=""chat-content"" style=""overflow-y: scroll !important; height:400px !important;"">
                 
");
#nullable restore
#line 18 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml"
                         foreach(var item in Model)
                        {
                            if(item.FromUser.FirstName==User.Identity.Name)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  <div class=\"media media-chat media-chat-reverse\">\r\n                            <div class=\"media-body\">\r\n                                <p>");
#nullable restore
#line 24 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml"
                              Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"meta\"><time datetime=\"2022\">");
#nullable restore
#line 25 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml"
                                                                 Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</time></p>\r\n                            </div>\r\n                                </div>\r\n");
#nullable restore
#line 28 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"media media-chat\"> <img class=\"avatar\" src=\"https://img.icons8.com/color/36/000000/administrator-male.png\" alt=\"...\">\r\n                            <div class=\"media-body\">\r\n                                <p>");
#nullable restore
#line 33 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml"
                              Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"meta\"><time datetime=\"2022\">");
#nullable restore
#line 34 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml"
                                                                 Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</time></p>\r\n                            </div>\r\n                                </div>\r\n");
#nullable restore
#line 37 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\Messages\GetConversation.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      
                     
                     
                   
                        <div class=""ps-scrollbar-x-rail"" style=""left: 0px; bottom: 0px;"">
                            <div class=""ps-scrollbar-x"" tabindex=""0"" style=""left: 0px; width: 0px;""></div>
                        </div>
                        <div class=""ps-scrollbar-y-rail"" style=""top: 0px; height: 0px; right: 2px;"">
                            <div class=""ps-scrollbar-y"" tabindex=""0"" style=""top: 0px; height: 2px;""></div>
                        </div>
                    </div>
                    <div class=""publisher bt-1 border-light""> <img class=""avatar avatar-xs"" src=""https://img.icons8.com/color/36/000000/administrator-male.png"" alt=""...""> 
                        <input class=""publisher-input"" type=""text"" placeholder=""Write something"">
                  
                           
                                <i class=""fa fa-smile""></i></a> <a class=""publisher-btn text-info"" href=""#"" dat");
            WriteLiteral("a-abc=\"true\">\r\n                                    <i class=\"fa fa-paper-plane\"></i></a> </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApartmentManagement.Domain.Entities.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591