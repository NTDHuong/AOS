#pragma checksum "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445d5267a9bf43406c84ab6b4c8a7614e351f2af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_PriceTable), @"mvc.1.0.view", @"/Views/Products/PriceTable.cshtml")]
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
#line 1 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\_ViewImports.cshtml"
using Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\_ViewImports.cshtml"
using Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445d5267a9bf43406c84ab6b4c8a7614e351f2af", @"/Views/Products/PriceTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_PriceTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
  

    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table style=""width: 70%; margin-left: auto; margin-right: auto; padding: 50px"" class=""table table-striped"">
    <thead>
        <tr>
            <th>#</th>
            <th>Tên sản phẩm</th>
            <th>Giá</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
          
            int count = 1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
               Write(item.OutPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
                  
                    count++;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\Products\PriceTable.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
