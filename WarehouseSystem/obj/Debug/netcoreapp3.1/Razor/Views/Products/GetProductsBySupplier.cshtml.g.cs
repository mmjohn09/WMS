#pragma checksum "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db341b3832cba6a916973334e0ecc2b8a165ef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GetProductsBySupplier), @"mvc.1.0.view", @"/Views/Products/GetProductsBySupplier.cshtml")]
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
#line 1 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\_ViewImports.cshtml"
using WarehouseSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\_ViewImports.cshtml"
using WarehouseSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db341b3832cba6a916973334e0ecc2b8a165ef7", @"/Views/Products/GetProductsBySupplier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af3c627ac9231ed21749f5d8ef0126cba3c0aa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_GetProductsBySupplier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WarehouseSystem.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
  
    ViewData["Title"] = "GetProductsBySupplier";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetProductsBySupplier</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.QtyOnHand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.MinimumQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.QtyOnHand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.MinimumQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Maggie34\workspace\WarehouseSystem\WarehouseSystem\Views\Products\GetProductsBySupplier.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WarehouseSystem.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591