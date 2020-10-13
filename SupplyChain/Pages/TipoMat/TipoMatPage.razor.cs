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

namespace SupplyChain.Pages.TipoMat
{
    public class TipoMatPageBase : ComponentBase
    {
        [Inject] protected CustomHttpClient Http { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }
        protected SfGrid<TipMat> Grid;

        public bool Enabled = true;
        public bool Disabled = false;


        protected List<TipMat> tipomats = new List<TipMat>();


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
            tipomats = await Http.GetFromJsonAsync<List<TipMat>>("api/TipoMat");
       

            await base.OnInitializedAsync();
        }

        public void ActionBeginHandler(ActionEventArgs<TipMat> args)
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

        public async Task ActionBegin(ActionEventArgs<TipMat> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                HttpResponseMessage response;
                bool found = tipomats.Any(p => p.Tipo == args.Data.Tipo);
                TipMat ur = new TipMat();

                if (!found)
                {
                    response = await Http.PostAsJsonAsync("api/TipoMat", args.Data);

                }
                else
                {

                    response = await Http.PutAsJsonAsync($"api/TipoMat/{args.Data.Tipo}", args.Data);
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

        private async Task EliminarOperario(ActionEventArgs<TipMat> args)
        {
            try
            {
                if (args.Data != null)
                {
                    bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea eliminar el Operario?");
                    if (isConfirmed)
                    {
                        //operarios.Remove(operarios.Find(m => m.CG_OPER == args.Data.CG_OPER));
                        await Http.DeleteAsync($"api/TipoMat/{args.Data.Tipo}");
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
                    foreach (TipMat selectedRecord in this.Grid.SelectedRecords)
                    {
                        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea copiar el Operario?");
                        if (isConfirmed)
                        {
                            TipMat Nuevo = new TipMat();

                            //Nuevo.CG_OPER = operarios.Max(s => s.CG_OPER) + 1;
                            Nuevo.Cg_cia = selectedRecord.Cg_cia;
                   

                            var response = await Http.PostAsJsonAsync("api/TipoArea", Nuevo);

                            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                            {
                                Grid.Refresh();
                                var tipomat = await response.Content.ReadFromJsonAsync<TipMat>();
                                await InvokeAsync(StateHasChanged);
                                Nuevo.Tipo = tipomat.Tipo;
                                tipomats.Add(Nuevo);
                                var itemsJson = JsonSerializer.Serialize(tipomat);
                                Console.WriteLine(itemsJson);
                                //toastService.ShowToast($"Registrado Correctemente.Vale {StockGuardado.VALE}", TipoAlerta.Success);
                                tipomats.OrderByDescending(p => p.Tipo);
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
