#pragma checksum "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0da5c80d88a7f40d1fbe1a4e10505f673f4fe84e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrdersAdmin_Details), @"mvc.1.0.view", @"/Views/OrdersAdmin/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0da5c80d88a7f40d1fbe1a4e10505f673f4fe84e", @"/Views/OrdersAdmin/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc6b55325b0ab971ba758bcc34a0cc77645e073f", @"/Views/_ViewImports.cshtml")]
    public class Views_OrdersAdmin_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shop.Models.OrderDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
  
    
    ViewData["Title"] = "Details";
    var format = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
   
    <!-- cart main wrapper start -->
    <div class=""cart-main-wrapper section-padding"">
        <div class=""container"">
            <div class=""section-bg-color"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <!-- Cart Table Area -->
                        <div class=""cart-table table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th class=""pro-thumbnail"">Image</th>
                                        <th class=""pro-title"">Name</th>
                                        <th class=""pro-price"">Price</th>
                                        <th class=""pro-quantity"">Quantity</th>
                                        <th class=""pro-subtotal"">Total</th>
                      
                                    </tr>
                                </thead>
    ");
            WriteLiteral("                            <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n");
#nullable restore
#line 36 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                              
                                                string[] arrListStr = item.Product.ProductImage.Split(' ');
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"pro-thumbnail\"><a");
            BeginWriteAttribute("href", " href=\"", 1664, "\"", 1704, 2);
            WriteAttributeValue("", 1671, "/Products/Details/", 1671, 18, true);
#nullable restore
#line 39 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
WriteAttributeValue("", 1689, item.ProductId, 1689, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0da5c80d88a7f40d1fbe1a4e10505f673f4fe84e6845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1734, "~/images/", 1734, 9, true);
#nullable restore
#line 39 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
AddHtmlAttributeValue("", 1743, arrListStr[0], 1743, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-title\"><a");
            BeginWriteAttribute("href", " href=\"", 1854, "\"", 1894, 2);
            WriteAttributeValue("", 1861, "/Products/Details/", 1861, 18, true);
#nullable restore
#line 40 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
WriteAttributeValue("", 1879, item.ProductId, 1879, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                                                                                         Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-price\"><span>");
#nullable restore
#line 41 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                                                   Write(String.Format(format,"{0:c0}", @item.Product.OutPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</span></td>\r\n                                            <td class=\"pro-quantity\"><div class=\"pro-quantity\"><div");
            BeginWriteAttribute("class", " class=\"", 2173, "\"", 2181, 0);
            EndWriteAttribute();
            WriteLiteral("> <span> ");
#nullable restore
#line 42 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                                                                                                Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    </div>\r\n                                                    </div>\r\n                                            </td>\r\n");
#nullable restore
#line 46 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                              
                                                var pricetotla = item.Quantity * item.Price;
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"pro-subtotal\"><span>");
#nullable restore
#line 49 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                                                      Write(String.Format(format, "{0:c0}", @pricetotla));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                           \r\n                                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                     
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <!-- Cart Update Option -->
                     
                    </div>
                </div>
       
            </div>
        </div>
    </div>
    <!-- cart main wrapper end -->
</main>
<div class=""offcanvas-minicart-wrapper"">
    <div class=""minicart-inner"">
        <div class=""offcanvas-overlay""></div>
        <div class=""minicart-inner-content"">
            <div class=""minicart-close"">
                <i class=""pe-7s-close""></i>
            </div>
            <div class=""minicart-content-box"">
                <div class=""minicart-item-wrapper"">
");
#nullable restore
#line 76 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                      
                        Double totlalprice = 0;
                        IEnumerable<OrderDetail> orderderail = ViewData["orderdeatail"] as IEnumerable<OrderDetail>;
                        if (orderderail == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"minicart-item\">\r\n\r\n                            </li>\r\n");
#nullable restore
#line 84 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                             foreach (OrderDetail ord in orderderail)
                            {
                                totlalprice += Convert.ToDouble(ord.Price * ord.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"minicart-item\">\r\n                                    <div class=\"minicart-thumb\">\r\n");
#nullable restore
#line 92 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                          
                                            string[] arrListStr = ord.Product.ProductImage.Split(' ');
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"product-details.html\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0da5c80d88a7f40d1fbe1a4e10505f673f4fe84e14203", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4680, "~/images/", 4680, 9, true);
#nullable restore
#line 96 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
AddHtmlAttributeValue("", 4689, arrListStr[0], 4689, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                    </div>
                                    <div class=""minicart-content"">
                                        <h6 class=""product-name"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 4992, "\"", 5032, 2);
            WriteAttributeValue("", 4999, "/Products/Details/", 4999, 18, true);
#nullable restore
#line 101 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
WriteAttributeValue("", 5017, ord.Product.Id, 5017, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 101 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                                                                   Write(ord.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </h6>\r\n                                        <p>\r\n                                            <span class=\"cart-quantity\">");
#nullable restore
#line 104 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                                                   Write(ord.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong>&times;</strong></span>\r\n                                            <span class=\"cart-price\"></span>\r\n                                        </p>\r\n                                    </div>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5480, "\"", 5511, 2);
            WriteAttributeValue("", 5487, "/AddOrder/Delete/", 5487, 17, true);
#nullable restore
#line 108 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
WriteAttributeValue("", 5504, ord.Id, 5504, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"minicart-remove\"><i class=\"pe-7s-close\"></i></a>\r\n                                </li>\r\n");
#nullable restore
#line 110 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                             
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n                <div class=\"minicart-pricing-box\">\r\n                    <ul>\r\n                        <li class=\"total\">\r\n                            <span>total</span>\r\n                            <span><strong>");
#nullable restore
#line 119 "C:\Users\Laptop\OneDrive\Desktop\a\AOS\Views\OrdersAdmin\Details.cshtml"
                                     Write(String.Format(format, "{0:c0}", @totlalprice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></span>
                        </li>
                    </ul>
                </div>

                <div class=""minicart-button"">
                    <a href=""/OrderDetails""><i class=""fa fa-shopping-cart""></i> View Cart</a>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shop.Models.OrderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
