using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Costofab")]
    public class Costofab
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo Orden de Fabricacion")]
        public int CG_ORDF { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Pedido")]
        public int PEDIDO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo de material")]
        public string CG_MAT { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo de producto")]
        public string CG_PROD { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo de form")]
        public int CG_FORM { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Serie")]
        public string SERIE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Descripcion Producto")]
        public string DES_PROD { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Costo Real")]
        public decimal COSTOREAL { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Cantidad")]
        public decimal CANT { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Cantidad Fabricada")]
        public decimal CANTFAB { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Cantidad Vendida")]
        public decimal CANTVEND { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Precio")]
        public decimal PRECIO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Dolares")]
        public decimal DOLARES { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion")]
        public string DESCRIP { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Unidad")]
        public string UNID { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Costo Indice Hora")]
        public decimal COSTINDHORA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo indice")]
        public decimal COSTIND { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo distribuidor")]
        public decimal COSTDISTR { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo Unidad")]
        public decimal COSUNI { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo material")]
        public decimal COTOMA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo remate")] //???
        public decimal COREMA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Procesos")]
        public string PROCESOS { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Total segundos")]
        public decimal TOTSEG { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Tiempo setup")]
        public decimal TIEMPOSETUP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo mantenimiento")]
        public decimal COSMAN { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo mantenimiento sup")]
        public decimal COSMANSUP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Terceros")]
        public string TERCEROS { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Tiempo in")]
        public decimal TIEMPOIN { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Cosinteo")]
        public decimal COSINTEO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "COSTER")]
        public decimal COSTER { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Total producto")]
        public decimal TOTALPROD { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Peso")]
        public decimal PESO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo")]
        public string CODIGO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Costsup")]
        public decimal COSTSUP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo combinado")]
        public decimal COSTCOMB { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo energia")]
        public decimal COSTENERG { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costoac")]
        public decimal COSTOAC { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo Alquiler")]
        public decimal COSTOALQUI { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo Celda")]
        public decimal COSTOCELDA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo repuesto")]
        public decimal COSTOREP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Plantel")]
        public decimal PLANTEL { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Fecha Fabricacion")]
        public DateTime FE_FAB { get; set; }
        [ColumnaGridViewAtributo(Name = "Registro")]
        public int REGISTRO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Registro Pedido")]
        public int REGISTROPED { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "No procesado")]
        public decimal NOPROC { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo Compañia")]
        public int CG_CIA { get; set; } = 0;
    }
}
