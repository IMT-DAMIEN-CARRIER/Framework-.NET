#pragma checksum "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8607a03694ae94d3c6247449487cc1d19e469b33"
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
 if (_categories != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                      _category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                HandleFilter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n        \n        ");
                __builder2.AddMarkupContent(9, "<label>Filtrer la recherche</label>\n\n        ");
                __Blazor.BlogBlazor.Client.Pages.Posts.TypeInference.CreateInputSelect_0(__builder2, 10, 11, 
#nullable restore
#line 13 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                   _category

#line default
#line hidden
#nullable disable
                , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _category = __value, _category)), 13, () => _category, 14, (__builder3) => {
                    __builder3.AddMarkupContent(15, "<option value=\"0\"></option>");
#nullable restore
#line 15 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
             foreach (var item in _categories)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(16, "option");
                    __builder3.AddAttribute(17, "value", 
#nullable restore
#line 17 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(18, 
#nullable restore
#line 17 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                          item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 18 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(19, "\n\n        ");
                __builder2.AddMarkupContent(20, "<button class=\"btn btn-primary\" type=\"submit\">Filtrer</button>\n        ");
                __builder2.AddMarkupContent(21, "<a href=\"/posts/add\">Ajout une publication</a>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 24 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
 if (_posts != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
     foreach (var item in _posts)
    {
        if (@item.PublicationDate <= DateTime.Now)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "<p class=\"font-weight-bold\">Name :</p> ");
            __builder.AddContent(24, 
#nullable restore
#line 33 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                        item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\n                ");
            __builder.AddMarkupContent(26, "<p class=\"font-weight-bold\">Description :</p> ");
            __builder.AddContent(27, 
#nullable restore
#line 34 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                               item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\n                ");
            __builder.AddMarkupContent(29, "<p class=\"font-weight-bold\">Date de création :</p> ");
            __builder.AddContent(30, 
#nullable restore
#line 35 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                                    item.PublicationDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\n                ");
            __builder.AddMarkupContent(32, "<p class=\"font-weight-bold\">Contenu : </p> ");
            __builder.AddContent(33, 
#nullable restore
#line 36 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                            item.Content

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\n                ");
            __builder.AddMarkupContent(35, "<p class=\"font-weight-bold\">Catégorie : </p> ");
            __builder.AddContent(36, 
#nullable restore
#line 37 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                              item.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "\n                ");
            __builder.AddMarkupContent(38, "<p class=\"font-weight-bold\">Auteur : </p> ");
            __builder.AddContent(39, 
#nullable restore
#line 38 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                           item.Author.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\n                ");
            __builder.AddMarkupContent(41, "<p class=\"font-weight-bold\">Détails : </p> ");
            __builder.AddContent(42, 
#nullable restore
#line 39 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
                                                            item.Author.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n            ");
            __builder.AddMarkupContent(44, "<div><a href=\"/post/\" + @item.Id>Détails</a></div>");
#nullable restore
#line 44 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/Users/dams/IMT/3A/dotnet/framework-dot-net/tp_noté/BlogBlazor/BlogBlazor/Client/Pages/Posts.razor"
       
    private PostReadDTO[] _posts;
    private CategoryReadDTO[] _categories;
    private CategoryReadDTO _category = new();

    protected async override Task OnInitializedAsync()
    {
        _posts = await Http.GetFromJsonAsync<PostReadDTO[]>("api/post");
        _categories = await Http.GetFromJsonAsync<CategoryReadDTO[]>("api/category");
    }

    protected async Task HandleFilter()
    {
        if (_category != null)
        {
            _posts = await Http.GetFromJsonAsync<PostReadDTO[]>("api/post" + _category.Name);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlogBlazor.Client.Pages.Posts
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
