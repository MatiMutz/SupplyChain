#pragma checksum "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da483069ecae17ba543dfe96e6a87328763a88e"
// <auto-generated/>
#pragma warning disable 1591
namespace SupplyChain.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using System.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "nav flex-row");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "li");
            __builder.AddAttribute(4, "class", "nav-item");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "class", "nav-link");
            __builder.AddAttribute(8, "href", "");
            __builder.AddAttribute(9, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 46 "E:\SupplyChain\SupplyChain\SUPPLYCHAIN\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n                <span aria-hidden=\"true\"></span>Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "nav-item");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "class", "nav-link");
            __builder.AddAttribute(19, "href", "operario/list");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n                <span aria-hidden=\"true\"></span>Lista Operarios\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "nav-item");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "class", "nav-link");
            __builder.AddAttribute(29, "href", "/operacionesstock");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(31, "\r\n                <span aria-hidden=\"true\"></span>Operaciones de Stock\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "nav-item");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "class", "nav-link");
            __builder.AddAttribute(39, "href", "servicio/list");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n                <span aria-hidden=\"true\"></span>Módulo Servicios\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "nav-item");
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "nav-link");
            __builder.AddAttribute(49, "href", "Prod/list");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "\r\n                <span aria-hidden=\"true\"></span>Lista productos\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
