using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Prod")]
    public class Prod
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo de producto")]
        public int CG_PROD { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion de producto")]
        public string DES_PROD { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo de Orden")]
        public int CG_ORDEN { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Tipo")]
        public string TIPO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo de clase")]
        public int CG_CLAS { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Unidad")]
        public string UNID { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Factor de conversion")]
        public decimal CG_DENSEG { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad secundaria")]
        public string UNIDSEG { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Peso")]
        public decimal PESO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Unidad de peso")]
        public string UNIDPESO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Especificaciones")]
        public string ESPECIF { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Norma")]
        public string NORMA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Exige despacho")]
        public int EXIGEDESPACHO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Exige Lote")]
        public int EXIGELOTE { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Exige Serie")]
        public int EXIGESERIE { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Exige Orden de Armado")]
        public int EXIGEOA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Stock minimo")]
        public decimal STOCKMIN { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Lote optimo")]
        public decimal LOPTIMO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo de Area")]
        public int CG_AREA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo de linea")]
        public int CG_LINEA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Activo")]
        public string ACTIVO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Tiempo de Fabricacion")]
        public decimal TIEMPOFAB { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo")]
        public decimal COSTO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo prod terminado")]
        public decimal COSTOTER { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo de Celda")]
        public string CG_CELDA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo tipo de area")]
        public int CG_TIPOAREA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo de cuenta 1")]
        public decimal CG_CUENT1 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Unidad equivalente")]
        public decimal UNIDEQUI { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "costo unidad de compra")]
        public decimal COSTOUC { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "moneda unidad de compra")]
        public string MONEDAUC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "costo unidad de compra 1")]
        public decimal COSTOUC1 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "fecha unidad de compra")]
        public DateTime FE_UC { get; set; }
        [ColumnaGridViewAtributo(Name = "usuario")]
        public string USUARIO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "fecha de reg")]
        public DateTime FE_REG { get; set; }
        [ColumnaGridViewAtributo(Name = "codigo de compañia")]
        public int CG_CIA { get; set; } = 0;
    }
}
