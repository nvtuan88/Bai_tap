#pragma checksum "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd9e93a3247c779ad802ab60bcd6c45cd4dfb90"
// <auto-generated/>
#pragma warning disable 1591
namespace MediaPlay.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
using MediaPlay.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
using MediaPlay.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:url(\'" + (
#nullable restore
#line 11 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                                                product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h4");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 13 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-footer");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                  (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "class", "btn btn-info btn-lg");
            __builder.AddAttribute(26, "data-toggle", "modal");
            __builder.AddAttribute(27, "data-target", "#myModal");
            __builder.AddContent(28, "More Info");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal fade");
            __builder.AddAttribute(36, "id", "myModal");
            __builder.AddAttribute(37, "role", "dialog");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal-dialog");
            __builder.AddMarkupContent(41, "\r\n\r\n            \r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "modal-content");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-header");
            __builder.AddMarkupContent(47, "\r\n\r\n                    ");
            __builder.OpenElement(48, "h4");
            __builder.AddAttribute(49, "class", "modal-title");
            __builder.AddContent(50, 
#nullable restore
#line 33 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                             selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.AddMarkupContent(52, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-body");
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "card-img");
            __builder.AddAttribute(59, "style", "background-image:url(\'" + (
#nullable restore
#line 38 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                                                        selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "card");
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "card-body");
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.OpenElement(67, "p");
            __builder.AddAttribute(68, "class", "card-text");
            __builder.AddContent(69, 
#nullable restore
#line 41 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "a");
            __builder.AddAttribute(72, "href", 
#nullable restore
#line 42 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                      selectedProduct.Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(73, "target", "_blank");
            __builder.AddAttribute(74, "class", "btn btn-primary");
            __builder.AddContent(75, "Xem Phim");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "card-footer");
            __builder.AddMarkupContent(82, "\r\n");
#nullable restore
#line 48 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "                        ");
            __builder.AddMarkupContent(84, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 51 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "                        ");
            __builder.OpenElement(86, "span");
            __builder.AddContent(87, 
#nullable restore
#line 54 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(88, " ");
            __builder.AddContent(89, 
#nullable restore
#line 54 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 55 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 57 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                     for (int i = 1; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i < currentRating)
                        {
                            

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                            ");
            __builder.OpenElement(93, "span");
            __builder.AddAttribute(94, "class", "fa fa-star");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 68 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
#nullable restore
#line 75 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Admin\source\repos\HelloWebform\MediaPlay\Component\ProductList.razor"
       
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(e => e.Id == productId);
        GetCurrentRating();
    }
    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectedProduct.Rating == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Rating.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Rating.Sum() / voteCount;
        }
        System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedProduct.Id} : {currentRating}");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
