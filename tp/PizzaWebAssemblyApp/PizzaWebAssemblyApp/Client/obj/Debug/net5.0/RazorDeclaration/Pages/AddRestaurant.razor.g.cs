// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PizzaWebAssemblyApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using PizzaWebAssemblyApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using PizzaWebAssemblyApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/_Imports.razor"
using PizzaWebAssemblyApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/restaurants/add")]
    public partial class AddRestaurant : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp/PizzaWebAssemblyApp/PizzaWebAssemblyApp/Client/Pages/AddRestaurant.razor"
       
    private PizzaWebAssemblyApp.Shared.Restaurant _restaurant = new();

    protected async Task HandleValidSubmit()
    {
        await Http.PostAsJsonAsync("api/restaurant", _restaurant);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
