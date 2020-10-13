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

namespace SupplyChain.Pages.TiposNoConf
{
    public class TiposNoConfPageBase : ComponentBase
    {
        [Inject] protected CustomHttpClient Http { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }
        protected SfGrid<TipNoConf> Grid;

        public bool Enabled = true;
        public bool Disabled = false;


        protected List<TipNoConf> tiposnoconfs = new List<TipNoConf>();


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
            tiposnoconfs = await Http.GetFromJsonAsync<List<TipNoConf>>("api/TiposNoConf");
       

            await base.OnInitializedAsync();
        }

        public void ActionBeginHandler(ActionEventArgs<TipNoConf> args)
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

        public async Task ActionBegin(ActionEventArgs<TipNoConf> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                HttpResponseMessage response;
                bool found = tiposnoconfs.Any(p => p.Cg_TipoNc == args.Data.Cg_TipoNc);
                TipNoConf ur = new TipNoConf();

                if (!found)
                {
                    response = await Http.PostAsJsonAsync("api/TiposNoConf", args.Data);

                }
                else
                {

                    response = await Http.PutAsJsonAsync($"api/TiposNoConf/{args.Data.Cg_TipoNc}", args.Data);
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

        private async Task EliminarOperario(ActionEventArgs<TipNoConf> args)
        {
            try
            {
                if (args.Data != null)
                {
                    bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea eliminar el Operario?");
                    if (isConfirmed)
                    {
                        //operarios.Remove(operarios.Find(m => m.CG_OPER == args.Data.CG_OPER));
                        await Http.DeleteAsync($"api/TiposNoConf/{args.Data.Cg_TipoNc}");
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
                    foreach (TipNoConf selectedRecord in this.Grid.SelectedRecords)
                    {
                        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea copiar el Operario?");
                        if (isConfirmed)
                        {
                            TipNoConf Nuevo = new TipNoConf();

                            //Nuevo.CG_OPER = operarios.Max(s => s.CG_OPER) + 1;
                            Nuevo.Des_TipoNc = selectedRecord.Des_TipoNc;
                            Nuevo.Cg_cia = selectedRecord.Cg_cia;


                            var response = await Http.PostAsJsonAsync("api/TiposNoConf", Nuevo);

                            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                            {
                                Grid.Refresh();
                                var tiponoconf = await response.Content.ReadFromJsonAsync<TipNoConf>();
                                await InvokeAsync(StateHasChanged);
                                Nuevo.Cg_TipoNc = tiponoconf.Cg_TipoNc;
                                tiposnoconfs.Add(Nuevo);
                                var itemsJson = JsonSerializer.Serialize(tiponoconf);
                                Console.WriteLine(itemsJson);
                                //toastService.ShowToast($"Registrado Correctemente.Vale {StockGuardado.VALE}", TipoAlerta.Success);
                                tiposnoconfs.OrderByDescending(p => p.Cg_TipoNc);
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
