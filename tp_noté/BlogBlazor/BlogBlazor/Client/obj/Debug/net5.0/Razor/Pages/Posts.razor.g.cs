#pragma checksum "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c01f55742068cc90975da38182d504a20e6da3a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlogBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Shared.Model.Author;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Shared.Model.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Shared.Model.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/_Imports.razor"
using BlogBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Posts")]
    public partial class Posts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Nos publication</h3>");
#nullable restore
#line 5 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
 if (categories != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<p>Filtrer la recherche</p>\n        ");
            __builder.OpenElement(3, "select");
#nullable restore
#line 10 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
             foreach(item in categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "option");
            __builder.CloseElement();
#nullable restore
#line 13 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
 if (posts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div>loading...</div>");
#nullable restore
#line 21 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
}
else
{
    if (posts.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<div>Aucun posts</div>");
#nullable restore
#line 27 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
         foreach (var item in posts)
        {
            if (@item.PublicationDate <= DateTime.Now)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "<p class=\"font-weight-bold\">Name :</p> ");
            __builder.AddContent(9, 
#nullable restore
#line 34 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                             item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "<p class=\"font-weight-bold\">Description :</p> ");
            __builder.AddContent(13, 
#nullable restore
#line 35 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                                    item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "<p class=\"font-weight-bold\">Date de création :</p> ");
            __builder.AddContent(17, 
#nullable restore
#line 36 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                                         item.PublicationDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddMarkupContent(20, "<p class=\"font-weight-bold\">Contenu : </p> ");
            __builder.AddContent(21, 
#nullable restore
#line 37 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                                 item.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddMarkupContent(24, "<p class=\"font-weight-bold\">Catégorie :  </p> ");
            __builder.AddContent(25, 
#nullable restore
#line 38 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                                    item.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddMarkupContent(28, "<p class=\"font-weight-bold\">Auteur : </p> ");
            __builder.AddContent(29, 
#nullable restore
#line 39 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                                item.Author.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 40 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
         
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
       
    private List<PostReadDTO> posts;
    private List<CategoryReadDTO> categories;

    protected async override Task OnInitializedAsync()
    {
        posts = await Http.GetFromJsonAsync<List<PostReadDTO>>("api/post");
        categories = await Http.GetFromJsonAsync<List<CategoryReadDTO>>("api/category");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
