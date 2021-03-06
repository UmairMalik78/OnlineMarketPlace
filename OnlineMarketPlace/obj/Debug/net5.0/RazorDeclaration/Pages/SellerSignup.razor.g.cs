// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using OnlineMarketPlace.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/sellerSignup")]
    public partial class SellerSignup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "F:\Projects\Android\GtiProjects\EAD-Project\OnlineMarketPlace\OnlineMarketPlace\Pages\SellerSignup.razor"
       

    async Task submitForm()
    {
        Address address = new Address();
        UserItem userItem = new UserItem();
        Seller seller = new Seller();
        JArray obj = await checkEmailDuplication(sellerSignUp.Email);
        if (obj.Count==0) {
            address.City = sellerSignUp.City;
            address.Country = sellerSignUp.Country;
            address.PostalCode = sellerSignUp.PostalCode;
            address.StreetAddress = sellerSignUp.StreetAddress;
            address.State = sellerSignUp.State;
            int addressID = await addToDB("address", address);
            userItem.AddressId = addressID;
            userItem.Name = sellerSignUp.Name;
            userItem.Phone = sellerSignUp.Phone;
            userItem.Email = sellerSignUp.Email;
            userItem.DateOfBirth = null;
            userItem.Password = sellerSignUp.Password;
            int userItemID = await addToDB("userItem", userItem);
            seller.PaymentTypeId = 1;
            seller.ShopAddressId = addressID;
            seller.UserId = userItemID;
            await addToDB("seller", seller);
            NavManager.NavigateTo("/sellerSignin");
        }
        else {
            sellerSignUp.emailWarning = "Email already in use.";
        }


    }

    async Task<JArray> checkEmailDuplication(string email)
    {
        String jsonDataAsString;
        HttpClient http = new HttpClient();
        var requestMessage = new HttpRequestMessage()
        {
            Method = new HttpMethod("GET"),
            RequestUri = new Uri("http://localhost:5000/odata/userItem?$filter=email eq '" + email + "'")
        };
        var response = await http.SendAsync(requestMessage);
        jsonDataAsString = await response.Content.ReadAsStringAsync();
        var data = (JObject)JsonConvert.DeserializeObject(jsonDataAsString);
        return (JArray)data["value"];
    }
    async Task<int> addToDB<T>(string table, T obj)
    {
        var json = JsonConvert.SerializeObject(obj);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var url = "http://localhost:5000/odata/" + table;
        using var client = new HttpClient();
        var response = await client.PostAsync(url, data);
        var result = await response.Content.ReadAsStringAsync();
        var data1 = (JObject)JsonConvert.DeserializeObject(result);
        return Convert.ToInt32(data1["value"][0].ToString());

    }

    public class Seller
    {
        public int UserId { get; set; }
        public int ShopAddressId { get; set; }
        public int PaymentTypeId { get; set; }
    }

    public class Address
    {

        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
    }
    public class UserItem
    {
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }

    }

    public class SellerSignUp
    {
        public string emailWarning=null;
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string StreetAddress { get; set; }

    }
    SellerSignUp sellerSignUp = new SellerSignUp();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
