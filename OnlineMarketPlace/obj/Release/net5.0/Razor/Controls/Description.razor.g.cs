#pragma checksum "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d3c30329cc68681e0734c69a54924acec400ccb"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineMarketPlace.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using OnlineMarketPlace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using OnlineMarketPlace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using OnlineMarketPlace.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using OnlineMarketPlace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
    public partial class Description : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .list {\r\n        margin-top: 20px;\r\n        color: #8d8d8d;\r\n        font-family: \'Segoe UI\', Tahoma, Geneva, Verdana, sans-serif;\r\n        font-weight: bold;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "style", " margin-top: 20px; display: flex;list-style-type:none; border-bottom: 1px solid #d1cfcf;");
            __builder.OpenElement(5, "li");
            __builder.AddAttribute(6, "id", "desc");
            __builder.AddAttribute(7, "style", (
#nullable restore
#line 14 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor"
                              myStyle1

#line default
#line hidden
#nullable disable
            ) + " cursor:pointer");
            __builder.AddAttribute(8, "class", "list col-sm-3");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor"
                                            DisplaySeller

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n            Contact Seller\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, " &nbsp; &nbsp; &nbsp;\r\n\r\n        ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "id", "info");
            __builder.AddAttribute(14, "style", (
#nullable restore
#line 19 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor"
                              myStyle2

#line default
#line hidden
#nullable disable
            ) + " cursor:pointer");
            __builder.AddAttribute(15, "class", "list col-sm-3");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor"
                                            DisplayInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n            ADDITIONAL\r\n            INFORMATION\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, " &nbsp; &nbsp; &nbsp;\r\n\r\n        ");
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "id", "review");
            __builder.AddAttribute(21, "style", (
#nullable restore
#line 25 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor"
                                myStyle3

#line default
#line hidden
#nullable disable
            ) + " cursor:pointer");
            __builder.AddAttribute(22, "class", "list col-sm-3");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor"
                                            DisplayReview

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n            REVIEWS\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddContent(27, 
#nullable restore
#line 31 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor"
         MyDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Controls\Description.razor"
       
    string myStyle1;
    string myStyle2;
    string myStyle3;
    [Parameter]
    public RenderFragment MyDescription { get; set; }

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

    private void DisplaySeller()
    {
        myStyle1 = "color:#f5614d;border-bottom:1px solid #f5614d;";
        myStyle2 = "color:#8d8d8d;border-bottom:1px solid #8d8d8d;";
        myStyle3 = "color:#8d8d8d;border-bottom:1px solid #8d8d8d;";

        OnClickCallback.InvokeAsync("desc");
    }
    private void DisplayInfo()
    {
        myStyle1 = "color:#8d8d8d;border-bottom:1px solid #8d8d8d;";
        myStyle2 = "color:#f5614d;border-bottom:1px solid #f5614d;";
        myStyle3 = "color:#8d8d8d;border-bottom:1px solid #8d8d8d;";

        OnClickCallback.InvokeAsync("info");
    }
    private void DisplayReview()
    {
        myStyle1 = "color:#8d8d8d;border-bottom:1px solid #8d8d8d;";
        myStyle2 = "color:#8d8d8d;border-bottom:1px solid #8d8d8d;";
        myStyle3 = "color:#f5614d;border-bottom:1px solid #f5614d;";

        OnClickCallback.InvokeAsync("rev");
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
