using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain
{
    [Table("Prod")]
    public class Prod
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo de producto")]
        public string CG_PROD { get; set; } = "";
        
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
        [ColumnaGridViewAtributo(Name = "Activo")]
        public string ACTIVO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Tiempo de Fabricacion")]
        public decimal TIEMPOFAB { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "IMPA1")]
        public decimal IMPA1 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "IMPA2")]
        public decimal IMPA2 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "IMPB1")]
        public decimal IMPB1 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "IMPB2")]
        public decimal IMPB2 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "IMPC1")]
        public decimal IMPC1 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "IMPC2")]
        public decimal IMPC2 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo")]
        public decimal COSTO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Costo prod terminado")]
        public decimal COSTOTER { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "COSTOUCLOCAL")]
        public decimal COSTOUCLOCAL { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "COSTOUCDOL")]
        public decimal COSTOUCDOL { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "FE_UC")]
        public DateTime? FE_UC { get; set; }
        [ColumnaGridViewAtributo(Name = "Codigo de Celda")]
        public string CG_CELDA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo de Area")]
        public int CG_AREA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo de Linea")]
        public int CG_LINEA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo tipo de area")]
        public int CG_TIPOAREA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo de cuenta")]
        public decimal CG_CUENT { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "fecha de reg")]
        public DateTime? FE_REG { get; set; }
        [ColumnaGridViewAtributo(Name = "codigo de compañia")]
        public int CG_CIA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string USUARIO { get; set; } = "";
        
    }
}
