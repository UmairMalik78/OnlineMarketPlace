#pragma checksum "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c38e4e10a79e000e182c2601ad2c337a6a61fc1"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineMarketPlace.Pages
{
    #line hidden
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 3 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using OnlineMarketPlace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/sellerSignin")]
    public partial class SellerSignin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row my-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", " col-10 col-md-3 text-center p-5 m-auto");
            __builder.AddAttribute(4, "style", "border: 1px solid #DADCE0;border-radius: 10px;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "justify-content- center");
            __builder.AddMarkupContent(7, "<img src=\"images/DigitalEmporiumLogo.png\" height=\"150px\">\r\n            <br>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(8, "<span style=\"font-size: x-large;\">Seller Sign in</span>\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(9, "<span>to continue to start selling</span>\r\n            <br>\r\n            <br>\r\n            <br>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
                              sellerSignIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 26 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
                                                           submitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "style", "font-size: large;");
                __builder2.AddAttribute(19, "placeholder", "Enter your name");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
                                        sellerSignIn.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignIn.email = __value, sellerSignIn.email))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignIn.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignin.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 30 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
                                          ()=> sellerSignIn.email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n                <br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "type", "password");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "placeholder", "Enter your password");
                __builder2.AddAttribute(31, "style", "font-size: large;");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
                                                        sellerSignIn.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sellerSignIn.password = __value, sellerSignIn.password))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sellerSignIn.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                <br>\r\n                ");
                __Blazor.OnlineMarketPlace.Pages.SellerSignin.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 35 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
                                          ()=> sellerSignIn.password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n                <br>\r\n                ");
                __builder2.AddMarkupContent(39, "<button class=\"btn btn-primary\">Sign in</button>\r\n                <br>\r\n                <br>\r\n                ");
                __builder2.OpenElement(40, "span");
                __builder2.AddAttribute(41, "style", "color:red");
                __builder2.AddContent(42, 
#nullable restore
#line 40 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
                                         sellerSignIn.exists

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(44, "<a href=\"sellerSignup\">Don\'t have an account?</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignin.razor"
       
    async void submitForm()
    {
        JArray obj = await GetResponse(sellerSignIn.email, sellerSignIn.password);
        if (obj.Count == 0)
        {
            sellerSignIn.exists = "Invalid username or password.";
        }
        else
        {
            sellerSignIn.exists = null;
            int sellerID = Convert.ToInt32(obj[0]["Id"]);
            await sessionStorage.SetItemAsync("sellerID", sellerID);
            NavManager.NavigateTo("/sellerDashboard");

        }
    }
    async Task<JArray> GetResponse(string email, string password)
    {
        String jsonDataAsString;
        HttpClient http = new HttpClient();
        var requestMessage = new HttpRequestMessage()
        {
            Method = new HttpMethod("GET"),
            RequestUri = new Uri("http://localhost:5000/odata/userItem?$filter=email eq '" + email + "'and password eq '" + password + "'")
        };
        var response = await http.SendAsync(requestMessage);
        jsonDataAsString = await response.Content.ReadAsStringAsync();
        var data = (JObject)JsonConvert.DeserializeObject(jsonDataAsString);
        return (JArray)data["value"];
    }

    SellerSignIn sellerSignIn = new SellerSignIn();
    public class SellerSignIn
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        public string exists = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
namespace __Blazor.OnlineMarketPlace.Pages.SellerSignin
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
