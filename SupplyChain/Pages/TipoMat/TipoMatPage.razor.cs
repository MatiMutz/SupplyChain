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
        protected SfGrid<SupplyChain.Shared.Models.TipoMat> Grid;
        

        public bool Enabled = true;
        public bool Disabled = false;


        protected List<SupplyChain.Shared.Models.TipoMat> tipomats = new List<SupplyChain.Shared.Models.TipoMat>();


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
            tipomats = await Http.GetFromJsonAsync<List<SupplyChain.Shared.Models.TipoMat>>("api/TipoMat");
       

            await base.OnInitializedAsync();
        }

        public void ActionBeginHandler(ActionEventArgs<SupplyChain.Shared.Models.TipoMat> args)
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

        public async Task ActionBegin(ActionEventArgs<SupplyChain.Shared.Models.TipoMat> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                HttpResponseMessage response;
                bool found = tipomats.Any(p => p.TIPO == args.Data.TIPO);
                SupplyChain.Shared.Models.TipoMat ur = new SupplyChain.Shared.Models.TipoMat();

                if (!found)
                {
                    response = await Http.PostAsJsonAsync("api/TipoMat", args.Data);

                }
                else
                {

                    response = await Http.PutAsJsonAsync($"api/TipoMat/{args.Data.TIPO}", args.Data);
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

        private async Task EliminarOperario(ActionEventArgs<SupplyChain.Shared.Models.TipoMat> args)
        {
            try
            {
                if (args.Data != null)
                {
                    bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea eliminar el Operario?");
                    if (isConfirmed)
                    {
                        //operarios.Remove(operarios.Find(m => m.CG_OPER == args.Data.CG_OPER));
                        await Http.DeleteAsync($"api/TipoMat/{args.Data.TIPO}");
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
                    foreach (SupplyChain.Shared.Models.TipoMat selectedRecord in this.Grid.SelectedRecords)
                    {
                        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea copiar el Operario?");
                        if (isConfirmed)
                        {
                            SupplyChain.Shared.Models.TipoMat Nuevo = new SupplyChain.Shared.Models.TipoMat();

                            Nuevo.TIPO = tipomats.Max(s => s.TIPO) + 1;
                            Nuevo.CG_CIA = selectedRecord.CG_CIA;
                            Nuevo.USUARIO = selectedRecord.USUARIO;

                            


                            var response = await Http.PostAsJsonAsync("api/TipoArea", Nuevo);

                            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                            {
                                Grid.Refresh();
                                var tipomat = await response.Content.ReadFromJsonAsync<SupplyChain.Shared.Models.TipoMat>();
                                await InvokeAsync(StateHasChanged);
                                Nuevo.TIPO = tipomat.TIPO;
                                tipomats.Add(Nuevo);
                                var itemsJson = JsonSerializer.Serialize(tipomat);
                                Console.WriteLine(itemsJson);
                                //toastService.ShowToast($"Registrado Correctemente.Vale {StockGuardado.VALE}", TipoAlerta.Success);
                                tipomats.OrderByDescending(p => p.TIPO);
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
