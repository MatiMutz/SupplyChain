// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SupplyChain.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using SupplyChain.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using System.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Aerre\SupplyChain\SUPPLYCHAIN\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Aerre\SupplyChain\SUPPLYCHAIN\Pages\Shared\BuscadorOCompra.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
    public partial class BuscadorOCompra : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "E:\Aerre\SupplyChain\SUPPLYCHAIN\Pages\Shared\BuscadorOCompra.razor"
       

    private Dictionary<string, object> searchAttr = new Dictionary<string, object>()
    {
        {"title","Buscar" },
        {"type","button" }
    };

    [Parameter] public int? Valor { get; set; } = 0;
    [Parameter] public bool EsSoloLectura { get; set; } = false;
    [Parameter] public bool MostraBotonBusqueda { get; set; } = false;
    [Parameter] public bool HabilitaBotonBusqueda { get; set; } = true;
    [Parameter] public bool MostrarSpin { get; set; } = true;
    [Parameter] public EventCallback<Compra> OnOCSeleccionada { get; set; }
    [Parameter] public int? CodigoDeposito { get; set; }
    [Parameter] public string Remito { get; set; }
    [Parameter] public int? Tipoo { get; set; }

    private Compra[] ItemsABuscar = null;
    private string[] ColumnasBuscador = new string[] { "NUMERO", "CG_MAT", "AUTORIZADO", "DES_PROVE" };
    private string TituloBuscador = "Listado de Ordenes de Compra";
    private bool PopupBuscadorVisible = false;
    //private ButtonRenderStyle buttonRenderStyle = ButtonRenderStyle.Secondary;

    private async Task BuscarOCompras()
    {
        //Avisar con un cartel que se debe seleccionar deposito
        if (Tipoo == 5)
        {
            if (CodigoDeposito == null)
            {
                //toastService.ShowToast("Seleccione Deposito Ingreso", TipoAlerta.Info);
                return;
            }

            if (string.IsNullOrEmpty(Remito) || Remito.ToLower().Trim() == "﻿0000-00000000")
            {
                Console.WriteLine(Remito);
                //toastService.ShowToast("Seleccione Remito", TipoAlerta.Info);
                return;
            }

            PopupBuscadorVisible = true;
            ItemsABuscar = await Http.GetFromJsonAsync<Compra[]>("api/Compras");
            await InvokeAsync(StateHasChanged);
        }

        if (Tipoo == 6)//devol a provee
        {
            //NO SE CONTROLA DEPOSITO PORQUE SE OBTINE DE RESUMEN STOCK
            //if (CodigoDeposito == null)
            //{
            //    toastService.ShowToast("Seleccione Deposito Salida", TipoAlerta.Info);
            //    return;
            //}

            PopupBuscadorVisible = true;
            ItemsABuscar = await Http.GetFromJsonAsync<Compra[]>("api/Compras");
            await InvokeAsync(StateHasChanged);
        }




        //if (CodigoDeposito != null && (string.IsNullOrEmpty(Remito) || Remito.Trim() != "﻿0000-00000000"))
        //{
        //    PopupBuscadorVisible = true;
        //    ItemsABuscar = await Http.GetFromJsonAsync<Compra[]>("api/Compras");
        //    await InvokeAsync(StateHasChanged);
        //}
    }

    public async Task EnviarObjetoSeleccionado(object compra)
    {
        var oc = (Compra)compra;
        PopupBuscadorVisible = false;
        await OnOCSeleccionada.InvokeAsync(oc);
    }

    //private ButtonRenderStyle CambiarColorBorde()
    //{
    //    if (HabilitaBotonBusqueda)
    //    {
    //        buttonRenderStyle = ButtonRenderStyle.Danger;
    //        return buttonRenderStyle;
    //    }

    //    return buttonRenderStyle;
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomHttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
