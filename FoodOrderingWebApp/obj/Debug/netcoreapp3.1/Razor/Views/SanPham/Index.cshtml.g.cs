#pragma checksum "D:\Học tập\Năm 3\HKVI\framework\Đồ án\FoodOrderingWebApp-master\FoodOrderingWebApp\Views\SanPham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3804befc5a870a750bb50ba4f6d8ebf831042de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_Index), @"mvc.1.0.view", @"/Views/SanPham/Index.cshtml")]
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
#line 1 "D:\Học tập\Năm 3\HKVI\framework\Đồ án\FoodOrderingWebApp-master\FoodOrderingWebApp\Views\_ViewImports.cshtml"
using FoodOrderingWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Học tập\Năm 3\HKVI\framework\Đồ án\FoodOrderingWebApp-master\FoodOrderingWebApp\Views\_ViewImports.cshtml"
using FoodOrderingWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3804befc5a870a750bb50ba4f6d8ebf831042de", @"/Views/SanPham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05b1a04763ebca66ec179083c96e7b1b7217068", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "D:\Học tập\Năm 3\HKVI\framework\Đồ án\FoodOrderingWebApp-master\FoodOrderingWebApp\Views\SanPham\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container mt-5"">
        <div class=""row tm-content-row"">
            <div class=""col-sm-12 col-md-12 col-lg-8 col-xl-8 tm-block-col"">
                <div class=""tm-bg-primary-dark tm-block tm-block-products"">
                    <div class=""tm-product-table-container"">
                        <table class=""table table-hover tm-table-small tm-product-table"">
                            <thead>
                                <tr>
                                    <th scope=""col"">&nbsp;</th>
                                    <th scope=""col"">PRODUCT NAME</th>
                                    <th scope=""col"">UNIT SOLD</th>
                                    <th scope=""col"">IN STOCK</th>
                                    <th scope=""col"">EXPIRE DATE</th>
                                    <th scope=""col"">&nbsp;</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                        ");
            WriteLiteral(@"            <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 1</td>
                                    <td>1,450</td>
                                    <td>550</td>
                                    <td>28 March 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 2</td>
                                    <td>1,250</td>
                                    <td>750</td>
                                    <td>21 March 2019<");
            WriteLiteral(@"/td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 3</td>
                                    <td>1,100</td>
                                    <td>900</td>
                                    <td>18 Feb 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                               ");
            WriteLiteral(@"     </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 4</td>
                                    <td>1,400</td>
                                    <td>600</td>
                                    <td>24 Feb 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 5</td>
                                    <td>1,800<");
            WriteLiteral(@"/td>
                                    <td>200</td>
                                    <td>22 Feb 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 6</td>
                                    <td>1,000</td>
                                    <td>1,000</td>
                                    <td>20 Feb 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-a");
            WriteLiteral(@"lt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 7</td>
                                    <td>500</td>
                                    <td>100</td>
                                    <td>10 Feb 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                               ");
            WriteLiteral(@"     <td class=""tm-product-name"">Lorem Ipsum Product 8</td>
                                    <td>1,000</td>
                                    <td>600</td>
                                    <td>08 Feb 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 9</td>
                                    <td>1,200</td>
                                    <td>800</td>
                                    <td>24 Jan 2019</td>
                                    <td>
                                        <a href=");
            WriteLiteral(@"""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 10</td>
                                    <td>1,600</td>
                                    <td>400</td>
                                    <td>22 Jan 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
       ");
            WriteLiteral(@"                             <th scope=""row""><input type=""checkbox"" /></th>
                                    <td class=""tm-product-name"">Lorem Ipsum Product 11</td>
                                    <td>2,000</td>
                                    <td>400</td>
                                    <td>21 Jan 2019</td>
                                    <td>
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <!-- table container -->
                    <a href=""add-product.html""
                       class=""btn btn-primary btn-block text-uppercase mb-3"">Add new product</a>
                    <button class=""btn btn-primary btn-block te");
            WriteLiteral(@"xt-uppercase"">
                        Delete selected products
                    </button>
                </div>
            </div>
            <div class=""col-sm-12 col-md-12 col-lg-4 col-xl-4 tm-block-col"">
                <div class=""tm-bg-primary-dark tm-block tm-block-product-categories"">
                    <h2 class=""tm-block-title"">Product Categories</h2>
                    <div class=""tm-product-table-container"">
                        <table class=""table tm-table-small tm-product-table"">
                            <tbody>
                                <tr>
                                    <td class=""tm-product-name"">Product Category 1</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                      ");
            WriteLiteral(@"          </tr>
                                <tr>
                                    <td class=""tm-product-name"">Product Category 2</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""tm-product-name"">Product Category 3</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                  ");
            WriteLiteral(@"              <tr>
                                    <td class=""tm-product-name"">Product Category 4</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""tm-product-name"">Product Category 5</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
               ");
            WriteLiteral(@"                     <td class=""tm-product-name"">Product Category 6</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""tm-product-name"">Product Category 7</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""tm");
            WriteLiteral(@"-product-name"">Product Category 8</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""tm-product-name"">Product Category 9</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""tm-product-name"">Product Category 10");
            WriteLiteral(@"</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td class=""tm-product-name"">Product Category 11</td>
                                    <td class=""text-center"">
                                        <a href=""#"" class=""tm-product-delete-link"">
                                            <i class=""far fa-trash-alt tm-product-delete-icon""></i>
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <!-- table container -->
          ");
            WriteLiteral("          <button class=\"btn btn-primary btn-block text-uppercase mb-3\">\n                        Add new category\n                    </button>\n                </div>\n            </div>\n        </div>\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
