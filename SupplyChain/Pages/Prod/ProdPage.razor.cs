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
        protected SfGrid<Prodd> Grid;

        public bool Enabled = true;
        public bool Disabled = false;


        protected List<Prodd> prods = new List<Prodd>();


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
            prods = await Http.GetFromJsonAsync<List<Prodd>>("api/Prod");
       

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

        public async Task ActionBegin(ActionEventArgs<Prodd> args)
        {
            if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
            {
                HttpResponseMessage response;
                bool found = prods.Any(p => p.CG_PROD == args.Data.CG_PROD);
                ProdPage ur = new ProdPage();

                if (!found)
                {
                    response = await Http.PostAsJsonAsync("api/Prod", args.Data);

                }
                else
                {

                    response = await Http.PutAsJsonAsync($"api/Prod/{args.Data.CG_PROD}", args.Data);
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

        private async Task EliminarOperario(ActionEventArgs<Prodd> args)
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
                    foreach (Prodd selectedRecord in this.Grid.SelectedRecords)
                    {
                        bool isConfirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Seguro de que desea copiar el Operario?");
                        if (isConfirmed)
                        {
                            Prodd Nuevo = new Prodd();

                            //Nuevo.CG_OPER = operarios.Max(s => s.CG_OPER) + 1;
                            Nuevo.DES_PROD = selectedRecord.DES_PROD;
                            Nuevo.CG_ORDEN = selectedRecord.CG_ORDEN;
                            Nuevo.TIPO = selectedRecord.TIPO;
                            Nuevo.CG_CLAS = selectedRecord.CG_CLAS;
                            Nuevo.UNID = selectedRecord.UNID;
                            Nuevo.CG_DENSEG = selectedRecord.CG_DENSEG;
                            Nuevo.UNIDSEG = selectedRecord.UNIDSEG;
                            Nuevo.PESO = selectedRecord.PESO;
                            Nuevo.UNIDPESO = selectedRecord.UNIDPESO;
                            Nuevo.ESPECIF = selectedRecord.ESPECIF;
                            Nuevo.NORMA = selectedRecord.NORMA;
                            Nuevo.EXIGEDESPACHO = selectedRecord.EXIGEDESPACHO;
                            Nuevo.EXIGELOTE = selectedRecord.EXIGELOTE;
                            Nuevo.EXIGESERIE = selectedRecord.EXIGESERIE;
                            Nuevo.EXIGEOA = selectedRecord.EXIGEOA;
                            Nuevo.STOCKMIN = selectedRecord.STOCKMIN;
                            Nuevo.LOPTIMO = selectedRecord.LOPTIMO;
                            Nuevo.CG_AREA = selectedRecord.CG_AREA;
                            Nuevo.CG_LINEA = selectedRecord.CG_LINEA;
                            Nuevo.ACTIVO = selectedRecord.ACTIVO;
                            Nuevo.TIEMPOFAB = selectedRecord.TIEMPOFAB;
                            Nuevo.COSTO = selectedRecord.COSTO;
                            Nuevo.COSTOTER = selectedRecord.COSTOTER;
                            Nuevo.MONEDA = selectedRecord.MONEDA;
                            Nuevo.CG_CELDA = selectedRecord.CG_CELDA;
                            Nuevo.CG_TIPOAREA = selectedRecord.CG_TIPOAREA;
                            Nuevo.CG_CUENT1 = selectedRecord.CG_CUENT1;
                            Nuevo.UNIDEQUI = selectedRecord.UNIDEQUI;
                            Nuevo.COSTOUC = selectedRecord.COSTOUC;
                            Nuevo.MONEDAUC = selectedRecord.MONEDAUC;
                            Nuevo.COSTOUC1 = selectedRecord.COSTOUC1;
                            Nuevo.FE_UC = selectedRecord.FE_UC;
                            Nuevo.USUARIO = selectedRecord.USUARIO;
                            Nuevo.FE_REG = selectedRecord.FE_REG;
                            Nuevo.CG_CIA = selectedRecord.CG_CIA;
                           

                            var response = await Http.PostAsJsonAsync("api/Prod", Nuevo);

                            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                            {
                                Grid.Refresh();
                                var prod = await response.Content.ReadFromJsonAsync<Prodd>();
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
