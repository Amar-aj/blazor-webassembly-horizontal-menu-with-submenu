#pragma checksum "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa535d2d37dc3d823034f7e635d89bbdff015ff"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebTemplete.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using BlazorWebTemplete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using BlazorWebTemplete.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-primary border-bottom box-shadow mb-3 fixed-top");
            __builder.AddAttribute(2, "b-u70pqrss14");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "b-u70pqrss14");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand text-light\" href=\"/index\" b-u70pqrss14>Top Menu</a>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "navbar-toggler");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "button");
            __builder.AddAttribute(11, "data-toggle", "collapse");
            __builder.AddAttribute(12, "data-target", ".navbar-collapse");
            __builder.AddAttribute(13, "aria-controls", "navbarSupportedContent");
            __builder.AddAttribute(14, "aria-expanded", "false");
            __builder.AddAttribute(15, "aria-label", "Toggle navigation");
            __builder.AddAttribute(16, "b-u70pqrss14");
            __builder.AddMarkupContent(17, "<span class=\"navbar-toggler-icon\" b-u70pqrss14></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", (
#nullable restore
#line 11 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor"
                     NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse" + " d-sm-inline-flex" + " flex-sm-row-reverse");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor"
                                                                                                     CollapseNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "b-u70pqrss14");
            __builder.OpenComponent<MudBlazor.MudNavMenu>(23);
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(25, "ul");
                __builder2.AddAttribute(26, "class", "navbar-nav");
                __builder2.AddAttribute(27, "b-u70pqrss14");
                __builder2.OpenElement(28, "li");
                __builder2.AddAttribute(29, "b-u70pqrss14");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
                __builder2.AddAttribute(31, "class", "nav-link");
                __builder2.AddAttribute(32, "href", "index");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n                            Dashboard\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.OpenElement(36, "li");
                __builder2.AddAttribute(37, "b-u70pqrss14");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
                __builder2.AddAttribute(39, "class", "nav-link");
                __builder2.AddAttribute(40, "href", "counter");
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(42, "\r\n                            Counter\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.OpenElement(44, "li");
                __builder2.AddAttribute(45, "b-u70pqrss14");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(46);
                __builder2.AddAttribute(47, "class", "dropsubmenu nav-link");
                __builder2.AddAttribute(48, "href", "fetchdata");
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "\r\n                            Fetch Data\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(52, @"<li b-u70pqrss14><div class=""dropdown"" b-u70pqrss14><a class=""dropsubmenu nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" b-u70pqrss14>  Hover me  </a>
                            <div class=""dropdown-content dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"" b-u70pqrss14><a href=""fetchdata"" b-u70pqrss14>Link 1</a>
                                <a href=""#"" b-u70pqrss14>Link 2</a>
                                <a href=""#"" b-u70pqrss14>Link 3</a></div></div></li>
                    ");
                __builder2.AddMarkupContent(53, @"<li class=""dropdown"" b-u70pqrss14><a class=""dropsubmenu nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" b-u70pqrss14>
                            Dropdown link
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"" b-u70pqrss14><a class=""dropdown-item"" href=""#"" b-u70pqrss14>Action</a>
                            <a class=""dropdown-item"" href=""#"" b-u70pqrss14>Another action</a>
                            <a class=""dropdown-item"" href=""#"" b-u70pqrss14>Something else here</a></div></li>
                    ");
                __builder2.OpenElement(54, "li");
                __builder2.AddAttribute(55, "b-u70pqrss14");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(56);
                __builder2.AddAttribute(57, "class", "nav-link");
                __builder2.AddAttribute(58, "href", "");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor"
                                                                    ()=>expandTimeSubMenu= !expandTimeSubMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(61, "<span class=\"oi oi-clock\" aria-hidden=\"true\" b-u70pqrss14></span> Time Management\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 56 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor"
                         if (expandTimeSubMenu)
                        {
                            //expandSubMenu = !expandTimeSubMenu;

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(62, "ul");
                __builder2.AddAttribute(63, "class", "nav flex-column");
                __builder2.AddAttribute(64, "b-u70pqrss14");
                __builder2.OpenElement(65, "li");
                __builder2.AddAttribute(66, "class", "nav-item px-3");
                __builder2.AddAttribute(67, "b-u70pqrss14");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
                __builder2.AddAttribute(69, "class", "nav-link");
                __builder2.AddAttribute(70, "href", "");
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(72, "<span class=\"oi oi-calendar\" aria-hidden=\"true\" b-u70pqrss14></span> Leave\r\n                                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                ");
                __builder2.OpenElement(74, "li");
                __builder2.AddAttribute(75, "class", "nav-item px-3");
                __builder2.AddAttribute(76, "b-u70pqrss14");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(77);
                __builder2.AddAttribute(78, "class", "nav-link");
                __builder2.AddAttribute(79, "href", "");
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(81, "<span class=\"mat material-icons\" b-u70pqrss14>schedule</span> Schedule\r\n                                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                                ");
                __builder2.OpenElement(83, "li");
                __builder2.AddAttribute(84, "class", "nav-item px-3");
                __builder2.AddAttribute(85, "b-u70pqrss14");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(86);
                __builder2.AddAttribute(87, "class", "nav-link");
                __builder2.AddAttribute(88, "href", "");
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(90, "<span class=\"mat material-icons\" b-u70pqrss14>event_note</span> TimeSheet\r\n                                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 77 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "E:\Amar\dotnet\Blazor\BlazorWebTemplete\BlazorWebTemplete\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;
    private bool expandSubMenu;
    private bool expandTimeSubMenu;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    void CollapseNavMenu()
    {
        collapseNavMenu = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
