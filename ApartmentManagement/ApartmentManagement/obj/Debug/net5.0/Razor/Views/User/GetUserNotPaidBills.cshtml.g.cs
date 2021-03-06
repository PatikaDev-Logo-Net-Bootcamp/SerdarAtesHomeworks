#pragma checksum "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd8330fabb0a04b09136ce513fee6bc763c82e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetUserNotPaidBills), @"mvc.1.0.view", @"/Views/User/GetUserNotPaidBills.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
using ApartmentManagement.Business.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd8330fabb0a04b09136ce513fee6bc763c82e4", @"/Views/User/GetUserNotPaidBills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d008b0b4f5a0db9479da938df8eb7804bafcc95d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetUserNotPaidBills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BillDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
  
    ViewData["Title"] = "GetUserPaidBills";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>??denmemi?? Faturalar</h1>
<table class=""table"">
    <thead>
        <tr>
           
            <th>
                Fiyat
            </th>
            <th>
                Daire Numaras??
            </th>
            <th>
                Fatura Tarihi
            </th>
            <th>
                Fatura t??r??
            </th>
            <th>
         
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 32 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
           Write(Html.DisplayFor(modelItem => item.FlatNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
           Write(Html.DisplayFor(modelItem => item.BillDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
           Write(Html.DisplayFor(modelItem => item.BillTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n       \r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd8330fabb0a04b09136ce513fee6bc763c82e46435", async() => {
                WriteLiteral(" ??de ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
                                             WriteLiteral(item.Id);

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
            WriteLiteral(" \r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserNotPaidBills.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BillDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
