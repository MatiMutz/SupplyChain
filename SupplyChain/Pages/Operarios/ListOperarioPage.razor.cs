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

namespace SupplyChain.Pages.Operarios
{
    public class ListOperarioPageBase : ComponentBase
    {
        [Inject] protected CustomHttpClient Http { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }
        protected SfGrid<OperarioEntity> Grid;

        public bool Enabled = true;
        public bool Disabled = false;

        protected List<OperarioEntity> operarios = new List<OperarioEntity>();
        protected List<CatOpeEntity> categorias = new List<CatOpeEntity>();
        protected List<Usuario> usuarios = new List<Usuario>();
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
            operarios = await Http.GetFromJsonAsync<List<OperarioEntity>>("api/Operario");
            operarios = operarios.OrderByDescending(s => s.CG_OPER).ToList();
            categorias = await Http.GetFromJsonAsync<List<CatOpeEntity>>("api/CatOpe");
            usuarios = await Http.GetFromJsonAsync<List<Usuario>>("api/Usuarios");
            clientes = await Http.GetFromJsonAsync<List<Cliente>>("api/Cliente");
            monedas = await Http.GetFromJsonAsync<List<MonedasEntity>>("api/Monedas");
            turnos = await Http.GetFromJsonAsync<List<TurnosEntity>>("api/Turnos");

            await base.OnInitializedAsync();
        }

        public void ActionBeginHandler(ActionEventArgs<OperarioEntity> args)
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

        public async Task ActionBegin(ActionEventArgs<OperarioEntity> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                HttpResponseMessage response;
                bool found = operarios.Any(o => o.CG_OPER == args.Data.CG_OPER);
                OperarioEntity ur = new OperarioEntity();

                if (!found)
                {
                    response = await Http.PostAsJsonAsync("api/Operario", args.Data);

                }
                else
                {

                    response = await Http.PutAsJsonAsync($"api/Operario/{args.Data.CG_OPER}", args.Data);
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

        private async Task EliminarOperario(ActionEventArgs<OperarioEntity> args)
        {
            try
            {
                if (args.Data != null)
                {
                    bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea eliminar el Operario?");
                    if (isConfirmed)
                    {
                        //operarios.Remove(operarios.Find(m => m.CG_OPER == args.Data.CG_OPER));
                        await Http.DeleteAsync($"api/Operario/{args.Data.CG_OPER}");
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
                    foreach (OperarioEntity selectedRecord in this.Grid.SelectedRecords)
                    {
                        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea copiar el Operario?");
                        if (isConfirmed)
                        {
                            OperarioEntity Nuevo = new OperarioEntity();

                            //Nuevo.CG_OPER = operarios.Max(s => s.CG_OPER) + 1;
                            Nuevo.DES_OPER = selectedRecord.DES_OPER;
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

                            var response = await Http.PostAsJsonAsync("api/Operario", Nuevo);

                            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                            {
                                Grid.Refresh();
                                var operario = await response.Content.ReadFromJsonAsync<OperarioEntity>();
                                await InvokeAsync(StateHasChanged);
                                Nuevo.CG_OPER = operario.CG_OPER;
                                operarios.Add(Nuevo);
                                var itemsJson = JsonSerializer.Serialize(operario);
                                Console.WriteLine(itemsJson);
                                //toastService.ShowToast($"Registrado Correctemente.Vale {StockGuardado.VALE}", TipoAlerta.Success);
                                operarios.OrderByDescending(o => o.CG_OPER);
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
