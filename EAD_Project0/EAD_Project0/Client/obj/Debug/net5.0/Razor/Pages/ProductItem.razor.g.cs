#pragma checksum "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e5ad2e6b0c2f2ea0119402539832bcaf1a54b5"
// <auto-generated/>
#pragma warning disable 1591
namespace EAD_Project0.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using EAD_Project0.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using EAD_Project0.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using EAD_Project0.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\_Imports.razor"
using EAD_Project0.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "width: 18rem; margin:20px");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "class", "card-img-top");
            __builder.AddAttribute(5, "height", "150");
            __builder.AddAttribute(6, "src", 
#nullable restore
#line 2 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor"
                                                 ProductImage(Product.Category)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddContent(13, 
#nullable restore
#line 4 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor"
                                Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "card-text");
            __builder.AddContent(17, 
#nullable restore
#line 5 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor"
                              Product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "card-text");
            __builder.AddContent(21, 
#nullable restore
#line 6 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor"
                              Product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-footer");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "/showcatalog");
            __builder.AddAttribute(27, "class", 
#nullable restore
#line 8 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor"
                                           ButtonClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor"
                           async()=> await SelectedProduct.InvokeAsync(Product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, 
#nullable restore
#line 12 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor"
                ButtonTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\OneDrive\Desktop\a hamza\EAD_Project0\EAD_Project0\Client\Pages\ProductItem.razor"
       
    [Parameter]
    public Product Product { get; set; }

    [Parameter]
    public string ButtonTitle { get; set; }

    [Parameter]
    public string ButtonClass { get; set; }

    [Parameter]
    public EventCallback<Product> SelectedProduct { get; set; }

    //ye abi bnaya ha
    [Parameter]
    public EventCallback<int> Counter { get; set; }

    private string ProductImage(Category category)
    {

        return $"Images/{category.ToString().ToLower()}.jpg";

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591