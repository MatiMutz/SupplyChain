using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SupplyChain.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyChain.Pages.Stocks
{
    public class PageOperacionesStockBase : ComponentBase
    {
        [Inject] protected CustomHttpClient Http { get; set; }
        protected Shared.Models.Stock stockCabacera = new Shared.Models.Stock();
        protected Shared.Models.Stock StockGuardado = new Shared.Models.Stock();
        protected Tire selectedTire;
        protected bool DepositoSalidaSoloLectura = true;
        protected bool DepositoIngresoSoloLectura = true;
        protected Deposito SelectedDepositoOC = new Deposito();
        protected bool IsVisible { get; set; } = false;
        protected string labelClienteProveedor = "Cliente/Proveedor";
        //Producto[] Productos = null;
        protected Deposito[] Depositos = null;
        protected Shared.Models.Stock[] ItemsVale = null;

        #region "VARIABLES PARA EDITAR ITEMS DE LA GRILLA
        bool PermiteAgregarItem { get; set; } = false;
        bool PermiteEditarItem { get; set; } = false;
        bool PermiteEliminarItem { get; set; } = false;
        #endregion

        #region "PARA BUSCAR ORDENES DE COMPRAS"
        bool OCSoloLectura = true;
        bool HabilitaBotonOC = true;
        bool MostrarBotorOC = false;
        #endregion

        #region "PARA BUSCAR ORDENES DE FABRICACION"
        bool OFSoloLectura = true;
        bool HabilitaBotonOF = true;
        bool MostrarBotorOF = false;
        #endregion

        #region "DEPOSITOS"
        private Deposito selectedDepositoSalida = null;
        Deposito SelectedDepositoSalida
        {
            get => selectedDepositoSalida;
            set { selectedDepositoSalida = value; InvokeAsync(StateHasChanged); }
        }

        private Deposito selectedDepositoIngreso = null;
        Deposito SelectedDepositoIngreso
        {
            get => selectedDepositoIngreso;
            set { selectedDepositoIngreso = value; InvokeAsync(StateHasChanged); }
        }
        #endregion

        #region "TIPOO"
        protected void SelectedTireChanged(Tire tire)
        {
            selectedTire = tire;
            //DEPENDIENDO EL TIPOO HABILITAR CONTROLES EN LA PANTALLA


            StockGuardado.TIPOO = selectedTire.Tipoo;
            MostrarBotorOC = false;
            HabilitaBotonOC = false;
            OCSoloLectura = true;
            HabilitaBotonOF = false;
            OFSoloLectura = true;
            DepositoSalidaSoloLectura = true;
            DepositoIngresoSoloLectura = true;
            SelectedDepositoOC = new Deposito();

            if (selectedTire?.Tipoo == 5) //recep prove
            {
                HabilitaBotonOC = true;
                MostrarBotorOC = true;
                DepositoIngresoSoloLectura = false;
                labelClienteProveedor = "Proveedor:";
            }

            if (selectedTire?.Tipoo == 6)//dev prove
            {
                HabilitaBotonOC = true;
                MostrarBotorOC = true;
                DepositoSalidaSoloLectura = false;
                labelClienteProveedor = "Proveedor:";
            }

            if (selectedTire?.Tipoo == 10)
            {
                HabilitaBotonOF = true;
            }

            if (selectedTire?.Tipoo == 9)
            {
                DepositoIngresoSoloLectura = false;
                if (selectedDepositoIngreso?.CG_DEP == null || selectedDepositoIngreso?.CG_DEP == 0)
                {
                    //toastService.ShowToast("Seleccionar Deposito de Ingreso", TipoAlerta.Info);
                    return;
                }

                PermiteAgregarItem = true;
            }

            if (selectedTire?.Tipoo == 10) //Entrega de insumos a una orden de fabricación
            {
                PermiteEditarItem = true;
                OFSoloLectura = true;
                HabilitaBotonOF = true;
                MostrarBotorOF = true;

            }

            if (selectedTire?.Tipoo == 21)
            {
                PermiteAgregarItem = true;
            }

            StockGuardado.TIPOO = selectedTire?.Tipoo; // lo utilizo para pasar la variable a los items de la grilla.
            InvokeAsync(StateHasChanged);
        }
        #endregion


        protected override async Task OnInitializedAsync()
        {
            //stockCabacera.VALE = await Http.GetFromJsonAsync<int>($"api/Stock/GetMaxVale");
            //Depositos = await Http.GetFromJsonAsync<Deposito[]>("api/Depositos");
            //selectedDepositoSalida = Depositos.FirstOrDefault(d => d.CG_DEP == 0);
            //selectedDepositoIngreso = Depositos.FirstOrDefault(d => d.CG_DEP == 0);
            //await InvokeAsync(StateHasChanged);
            //ItemsVale = new List<Stock>().ToArray();
        }

        private void OpenDialog()
        {
            this.IsVisible = true;
        }

        private void OnOverlayclick(MouseEventArgs arg)
        {
            this.IsVisible = false;
        }

        protected void Submit()
        {
            Console.WriteLine("Formulario Enviado");
        }

        protected void CambiarTipoo(Syncfusion.Blazor.DropDowns.ChangeEventArgs<int?> tire)
        {
            stockCabacera.TIPOO = tire.Value.Value;
            Console.WriteLine($"Tire selecccionado {stockCabacera.TIPOO}");
        }
    }
}
