using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SupplyChain.Shared.Models;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;


namespace SupplyChain.Pages.Lineasx
{
    public class LineasxPageBase : ComponentBase
    {
        [Inject] protected CustomHttpClient Http { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }
        protected SfGrid<SupplyChain.Shared.Models.Lineas> Grid;

        public bool Enabled = true;
        public bool Disabled = false;


        protected List<SupplyChain.Shared.Models.Lineas> lineas = new List<SupplyChain.Shared.Models.Lineas>();


        protected List<Object> Toolbaritems = new List<Object>(){
        "Search",
        "Add",
        "Edit",
        "Delete",
        "Print",
        new ItemModel { Text = "Copy", TooltipText = "Copy", PrefixIcon = "e-copy", Id = "copy" },
        "ExcelExport"
    };

        protected override async Task OnInitializedAsync()
        {
            lineas = await Http.GetFromJsonAsync<List<SupplyChain.Shared.Models.Lineas>>("api/Lineas");
       

            await base.OnInitializedAsync();
        }

        public void ActionBeginHandler(ActionEventArgs<SupplyChain.Shared.Models.Lineas> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = true;
            }
        }
        public class Moneda
        {
            public string ID { get; set; }
            public string Text { get; set; }
        }
        List<Moneda> MonedaData = new List<Moneda> {
            new Moneda() { ID= "Mon1", Text= "Peso Argentino"},
            new Moneda() { ID= "Mon2", Text= "Dolar"},
            new Moneda() { ID= "Mon3", Text= "Euro"}
        };

        public class EstaActivo
        {
            public bool BActivo { get; set; }
            public string Text { get; set; }
        }
        protected List<EstaActivo> ActivoData = new List<EstaActivo> {
            new EstaActivo() { BActivo= true, Text= "SI"},
            new EstaActivo() { BActivo= false, Text= "NO"}};

        public async Task ActionBegin(ActionEventArgs<SupplyChain.Shared.Models.Lineas> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                HttpResponseMessage response;
                bool found = lineas.Any(p => p.CG_LINEA == args.Data.CG_LINEA);
                SupplyChain.Shared.Models.Lineas ur = new SupplyChain.Shared.Models.Lineas();

                if (!found)
                {
                    response = await Http.PostAsJsonAsync("api/Lineas", args.Data);

                }
                else
                {

                    response = await Http.PutAsJsonAsync($"api/Lineas/{args.Data.CG_LINEA}", args.Data);
                }

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {

                }
            }

            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
            {
                await EliminarOperario(args);
            }
        }

        private async Task EliminarOperario(ActionEventArgs<SupplyChain.Shared.Models.Lineas> args)
        {
            try
            {
                if (args.Data != null)
                {
                    bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea eliminar la clase?");
                    if (isConfirmed)
                    {
                        //operarios.Remove(operarios.Find(m => m.CG_OPER == args.Data.CG_OPER));
                        await Http.DeleteAsync($"api/Lineas/{args.Data.CG_LINEA}");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public async Task ClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (args.Item.Text == "Copy")
            {
                if (this.Grid.SelectedRecords.Count > 0)
                {
                    foreach (SupplyChain.Shared.Models.Lineas selectedRecord in this.Grid.SelectedRecords)
                    {
                        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea copiar la Clase?");
                        if (isConfirmed)
                        {
                            SupplyChain.Shared.Models.Lineas Nuevo = new SupplyChain.Shared.Models.Lineas();

                            Nuevo.CG_LINEA = lineas.Max(s => s.CG_LINEA) + 1;
                            Nuevo.DES_LINEA = selectedRecord.DES_LINEA;
                            Nuevo.CG_CIA = selectedRecord.CG_CIA;
                            Nuevo.USUARIO = selectedRecord.USUARIO;


                            var response = await Http.PostAsJsonAsync("api/Lineas", Nuevo);

                            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                            {
                                Grid.Refresh();
                                var scrap = await response.Content.ReadFromJsonAsync<SupplyChain.Shared.Models.Lineas>();
                                await InvokeAsync(StateHasChanged);
                                Nuevo.CG_LINEA = scrap.CG_LINEA;
                                lineas.Add(Nuevo);
                                var itemsJson = JsonSerializer.Serialize(scrap);
                                Console.WriteLine(itemsJson);
                                //toastService.ShowToast($"Registrado Correctemente.Vale {StockGuardado.VALE}", TipoAlerta.Success);
                                lineas.OrderByDescending(p => p.CG_LINEA);
                            }

                        }
                    }
                }
            }
            if (args.Item.Text == "Excel Export")
            {
                await this.Grid.ExcelExport();
            }
        }

        public void Refresh()
        {
            Grid.Refresh();

        }
    }
}
