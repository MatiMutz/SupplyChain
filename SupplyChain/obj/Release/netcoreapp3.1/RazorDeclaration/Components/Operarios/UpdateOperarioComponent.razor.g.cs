#pragma checksum "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\Components\Operarios\UpdateOperarioComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b4e2184b3be68f71d05ba1838a5ecdccdaa2d07"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SupplyChain.Components.Operarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using SupplyChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using SupplyChain.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using SupplyChain.Components.Operarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using System.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    public partial class UpdateOperarioComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Administrador\Desktop\SupplyChain\SupplyChain\Components\Operarios\UpdateOperarioComponent.razor"
       
    [Parameter]
    public string IdOperario { get; set; }
    OperarioEntity oOperarios = new OperarioEntity();

    protected override async Task OnInitializedAsync()
    {
        /*
        oOperarios = B_Operario.OperarioById(IdOperario);
        */
    }

    private void UpdateOperario()
    {
        /*B_Operario.UpdateOperario(oOperarios);*/
        NavManager.NavigateTo("operario/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
