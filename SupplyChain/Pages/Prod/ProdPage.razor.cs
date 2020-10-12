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

namespace SupplyChain.Pages.Prod
{
    public class ProdPageBase : ComponentBase
    {
        [Inject] protected CustomHttpClient Http { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }
        protected SfGrid<ProdPage> Grid;

        public bool Enabled = true;
        public bool Disabled = false;


        protected List<ProdPage> prods = new List<ProdPage>();
        protected List<OperarioEntity> operarios = new List<OperarioEntity>();
        protected List<CatOpeEntity> categorias = new List<CatOpeEntity>();
        protected List<UsuarioEntity> usuarios = new List<UsuarioEntity>();
        protected List<Cliente> clientes = new List<Cliente>();
        protected List<MonedasEntity> monedas = new List<MonedasEntity>();
        protected List<TurnosEntity> turnos = new List<TurnosEntity>();

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
            prods = await Http.GetFromJsonAsync<List<ProdPage>>("api/Prod");
            prods = prods.OrderByDescending(s => s.CG_PROD).ToList();
            categorias = await Http.GetFromJsonAsync<List<CatOpeEntity>>("api/CatOpe");
            usuarios = await Http.GetFromJsonAsync<List<UsuarioEntity>>("api/Usuarios");
            clientes = await Http.GetFromJsonAsync<List<Cliente>>("api/Cliente");
            monedas = await Http.GetFromJsonAsync<List<MonedasEntity>>("api/Monedas");
            turnos = await Http.GetFromJsonAsync<List<TurnosEntity>>("api/Turnos");

            await base.OnInitializedAsync();
        }

        public void ActionBeginHandler(ActionEventArgs<ProdPage> args)
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

        public async Task ActionBegin(ActionEventArgs<ProdPage> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                HttpResponseMessage response;
                bool found = prods.Any(p => p.CG_PRODS == args.Data.CG_PRODS);
                ProdPage ur = new ProdPage();

                if (!found)
                {
                    response = await Http.PostAsJsonAsync("api/Prod", args.Data);

                }
                else
                {

                    response = await Http.PutAsJsonAsync($"api/Prod/{args.Data.CG_PRODS}", args.Data);
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

        private async Task EliminarOperario(ActionEventArgs<ProdPage> args)
        {
            try
            {
                if (args.Data != null)
                {
                    bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea eliminar el Operario?");
                    if (isConfirmed)
                    {
                        //operarios.Remove(operarios.Find(m => m.CG_OPER == args.Data.CG_OPER));
                        await Http.DeleteAsync($"api/Prod/{args.Data.CG_PROD}");
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
                    foreach (ProdPage selectedRecord in this.Grid.SelectedRecords)
                    {
                        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea copiar el Operario?");
                        if (isConfirmed)
                        {
                            ProdPage Nuevo = new ProdPage();

                            //Nuevo.CG_OPER = operarios.Max(s => s.CG_OPER) + 1;
                            Nuevo.DES_PROD = selectedRecord.DES_PROD;
                            Nuevo.CG_TURNO = selectedRecord.CG_TURNO;
                            Nuevo.RENDIM = selectedRecord.RENDIM;
                            Nuevo.FE_FINAL = selectedRecord.FE_FINAL;
                            Nuevo.HS_FINAL = selectedRecord.HS_FINAL;
                            Nuevo.CG_CATEOP = selectedRecord.CG_CATEOP;
                            Nuevo.VALOR_HORA = selectedRecord.VALOR_HORA;
                            Nuevo.MONEDA = selectedRecord.MONEDA;
                            Nuevo.ACTIVO = selectedRecord.ACTIVO;
                            Nuevo.CG_CIA = selectedRecord.CG_CIA;
                            Nuevo.USUARIO = selectedRecord.USUARIO;

                            var response = await Http.PostAsJsonAsync("api/Prod", Nuevo);

                            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                            {
                                Grid.Refresh();
                                var prod = await response.Content.ReadFromJsonAsync<OperarioEntity>();
                                await InvokeAsync(StateHasChanged);
                                Nuevo.CG_PROD = prod.CG_PROD;
                                prods.Add(Nuevo);
                                var itemsJson = JsonSerializer.Serialize(prod);
                                Console.WriteLine(itemsJson);
                                //toastService.ShowToast($"Registrado Correctemente.Vale {StockGuardado.VALE}", TipoAlerta.Success);
                                prods.OrderByDescending(p => p.CG_PROD);
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
