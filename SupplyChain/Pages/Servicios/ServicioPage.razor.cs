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

namespace SupplyChain.Pages.Servicios
{
    public class ServicioPageBase : ComponentBase
    {
        [Inject] protected CustomHttpClient Http { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }
        protected SfGrid<Servicio> Grid;

        public bool Enabled = true;
        public bool Disabled = false;

        protected List<Servicio> servicios = new List<Servicio>();
        protected List<Model> modelos = new List<Model>();
        protected List<Medid> medidas = new List<Medid>();
        protected List<Serie> series = new List<Serie>();
        protected List<Orific> orificios = new List<Orific>();
        protected List<Sobrepres> sobrepresiones = new List<Sobrepres>();
        protected List<Tip> tipos = new List<Tip>();
        protected List<Estad> estados = new List<Estad>();
        protected List<TrabajosEfec> trabajosEfectuados = new List<TrabajosEfec>();
        protected List<Marc> marcas = new List<Marc>();
        protected List<OperarioEntity> operarios = new List<OperarioEntity>();

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
            servicios = await Http.GetFromJsonAsync<List<Servicio>>("api/Servicios");
            modelos = await Http.GetFromJsonAsync<List<Model>>("api/Modelo");
            medidas = await Http.GetFromJsonAsync<List<Medid>>("api/Medida");
            series = await Http.GetFromJsonAsync<List<Serie>>("api/Serie");
            orificios = await Http.GetFromJsonAsync<List<Orific>>("api/Orificio");
            sobrepresiones = await Http.GetFromJsonAsync<List<Sobrepres>>("api/Sobrepresion");
            tipos = await Http.GetFromJsonAsync<List<Tip>>("api/Tipo");
            estados = await Http.GetFromJsonAsync<List<Estad>>("api/Estado");
            trabajosEfectuados = await Http.GetFromJsonAsync<List<TrabajosEfec>>("api/TrabajosEfec");
            marcas = await Http.GetFromJsonAsync<List<Marc>>("api/Marca");
            operarios = await Http.GetFromJsonAsync<List<OperarioEntity>>("api/Operario");

            await base.OnInitializedAsync();
        }

        public void ActionBeginHandler(ActionEventArgs<Servicio> args)
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
        public async Task ActionBegin(ActionEventArgs<Servicio> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                HttpResponseMessage response;
                bool found = servicios.Any(o => o.PEDIDO == args.Data.PEDIDO);
                Servicio ur = new Servicio();

                if (!found)
                {
                    response = await Http.PostAsJsonAsync("api/Servicio", args.Data);

                }
                else
                {

                    response = await Http.PutAsJsonAsync($"api/Servicio/{args.Data.PEDIDO}", args.Data);
                }

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {

                }
            }

            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
            {
                await EliminarServicio(args);
            }
        }

        private async Task EliminarServicio(ActionEventArgs<Servicio> args)
        {
            try
            {
                if (args.Data != null)
                {
                    bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea eliminar el servicio / la reparacion?");
                    if (isConfirmed)
                    {
                        //servicios.Remove(servicios.Find(m => m.PEDIDO == args.Data.PEDIDO));
                        await Http.DeleteAsync($"api/Servicio/{args.Data.PEDIDO}");
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
                    foreach (Servicio selectedRecord in this.Grid.SelectedRecords)
                    {
                        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea copiar el Servicios / la reparacion?");
                        if (isConfirmed)
                        {
                            Servicio Nuevo = new Servicio();

                            //Nuevo.PEDIDO = operarios.Max(s => s.PEDIDO) + 1;
                            Nuevo.FECHA = selectedRecord.FECHA;
                            Nuevo.CLIENTE = selectedRecord.CLIENTE;
                            Nuevo.PLANTA = selectedRecord.PLANTA;
                            Nuevo.OCOMPRA = selectedRecord.OCOMPRA;
                            Nuevo.REMITOREC = selectedRecord.REMITOREC;
                            Nuevo.REMITO = selectedRecord.REMITO;
                            Nuevo.IDENTIFICACION = selectedRecord.IDENTIFICACION;
                            Nuevo.NSERIE = selectedRecord.NSERIE;
                            Nuevo.MARCA = selectedRecord.MARCA;
                            Nuevo.MODELO = selectedRecord.MODELO;
                            Nuevo.MEDIDA = selectedRecord.MEDIDA;
                            Nuevo.SERIE = selectedRecord.SERIE;
                            Nuevo.ORIFICIO = selectedRecord.ORIFICIO;
                            Nuevo.AREA = selectedRecord.AREA;
                            Nuevo.FLUIDO = selectedRecord.FLUIDO;
                            Nuevo.AÑO = selectedRecord.AÑO;
                            Nuevo.PRESION = selectedRecord.PRESION;
                            Nuevo.TEMP = selectedRecord.TEMP;
                            Nuevo.PRESIONBANCO = selectedRecord.PRESIONBANCO;
                            Nuevo.SOBREPRESION = selectedRecord.SOBREPRESION;
                            Nuevo.CONTRAPRESION = selectedRecord.CONTRAPRESION;
                            Nuevo.TIPO = selectedRecord.TIPO;
                            Nuevo.RESORTE = selectedRecord.RESORTE;
                            Nuevo.SERVICIO = selectedRecord.SERVICIO;
                            Nuevo.ENSRECEP = selectedRecord.ENSRECEP;
                            Nuevo.ESTADO = selectedRecord.ESTADO;
                            Nuevo.PRESIONRECEP = selectedRecord.PRESIONRECEP;
                            Nuevo.FUGAS = selectedRecord.FUGAS;
                            Nuevo.PRESIONFUGA = selectedRecord.PRESIONFUGA;
                            Nuevo.CAMBIOPRESION = selectedRecord.CAMBIOPRESION;
                            Nuevo.PRESIONSOLIC = selectedRecord.PRESIONSOLIC;
                            Nuevo.CAMBIOREPUESTO = selectedRecord.CAMBIOREPUESTO;
                            Nuevo.CODRESORTE = selectedRecord.CODRESORTE;
                            Nuevo.REPUESTOS = selectedRecord.REPUESTOS;
                            Nuevo.TRABAJOSEFEC = selectedRecord.TRABAJOSEFEC;
                            Nuevo.TRABAJOSACCES = selectedRecord.TRABAJOSACCES;
                            Nuevo.MANOMETRO = selectedRecord.MANOMETRO;
                            Nuevo.FECMANTANT = selectedRecord.FECMANTANT;
                            Nuevo.PEDIDOANT = selectedRecord.PEDIDOANT;
                            Nuevo.ENSAYOCONTRAP = selectedRecord.ENSAYOCONTRAP;
                            Nuevo.RESP = selectedRecord.RESP;
                            Nuevo.CONTROLO = selectedRecord.CONTROLO;
                            Nuevo.POP = selectedRecord.POP;
                            Nuevo.RESPTECNICO = selectedRecord.RESPTECNICO;
                            Nuevo.OPDS = selectedRecord.OPDS;
                            Nuevo.ACTA = selectedRecord.ACTA;
                            Nuevo.PRESENCIAINSPEC = selectedRecord.PRESENCIAINSPEC;
                            Nuevo.DESCARTICULO = selectedRecord.DESCARTICULO;
                            Nuevo.OBSERV = selectedRecord.OBSERV;

                            var response = await Http.PostAsJsonAsync("api/Servicio", Nuevo);

                            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                            {
                                Grid.Refresh();
                                var servicio = await response.Content.ReadFromJsonAsync<Servicio>();
                                await InvokeAsync(StateHasChanged);
                                Nuevo.PEDIDO = servicio.PEDIDO;
                                servicios.Add(Nuevo);
                                var itemsJson = JsonSerializer.Serialize(servicio);
                                Console.WriteLine(itemsJson);
                                //toastService.ShowToast($"Registrado Correctemente.Vale {StockGuardado.VALE}", TipoAlerta.Success);
                                servicios.OrderByDescending(o => o.PEDIDO);
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
