#pragma checksum "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22437224da12efdf9b2060a96a5a8600564d9b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ShoppingCart), @"mvc.1.0.razor-page", @"/Pages/ShoppingCart.cshtml")]
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
#line 1 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/_ViewImports.cshtml"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22437224da12efdf9b2060a96a5a8600564d9b00", @"/Pages/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d31117870c5d78b64a50f65829aac5dedcf1ea04", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShoppingCart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1> Your Shopping Cart </h1>

<table class=""table table-bordered table-striped"">

    <thead>
        <tr>
            <th>Item</th>
            <th>Quantity</th>
            <th>Price</th>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 20 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml"
         foreach (var i in Model.basket.Items)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 23 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml"
               Write(i.Books.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml"
               Write(i.Books.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml"
                Write(i.Quantity * @i.Books.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n            </tr>\n");
#nullable restore
#line 28 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml"

         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n    <tfooter>\n        <tr>\n            <td colspan=\"3\">Total: </td>\n            <td>$");
#nullable restore
#line 35 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml"
            Write(Model.basket.CalculateTotal().ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n\n    </tfooter>\n\n</table>\n\n<div>\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 826, "\"", 849, 1);
#nullable restore
#line 43 "/Users/seungeunlee/Projects/Bookstore/Bookstore/Pages/ShoppingCart.cshtml"
WriteAttributeValue("", 833, Model.ReturnUrl, 833, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Pages.ShoppingCartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bookstore.Pages.ShoppingCartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bookstore.Pages.ShoppingCartModel>)PageContext?.ViewData;
        public Bookstore.Pages.ShoppingCartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
