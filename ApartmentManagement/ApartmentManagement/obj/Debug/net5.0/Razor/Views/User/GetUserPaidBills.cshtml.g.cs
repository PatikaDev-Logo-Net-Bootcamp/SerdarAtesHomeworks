#pragma checksum "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851cfc7960d9e9b0065ad4499866d0a3e21a68a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetUserPaidBills), @"mvc.1.0.view", @"/Views/User/GetUserPaidBills.cshtml")]
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
#line 1 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml"
using ApartmentManagement.Business.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851cfc7960d9e9b0065ad4499866d0a3e21a68a8", @"/Views/User/GetUserPaidBills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d008b0b4f5a0db9479da938df8eb7804bafcc95d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetUserPaidBills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BillDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml"
  
    ViewData["Title"] = "GetUserPaidBills";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>
                Fiyat
            </th>
            <th>
                Daire Numarası
            </th>
            <th>
                Fatura Tarihi
            </th>
            <th>
                Fatura türü
            </th>
            <th>
         
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml"
           Write(Html.DisplayFor(modelItem => item.FlatNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml"
           Write(Html.DisplayFor(modelItem => item.BillDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml"
           Write(Html.DisplayFor(modelItem => item.BillTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n       \r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Serdar\Documents\GitHub\SerdarAtesHomeworks\ApartmentManagement\ApartmentManagement\Views\User\GetUserPaidBills.cshtml"
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
