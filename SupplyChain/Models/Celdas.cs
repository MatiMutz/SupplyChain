using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Celdas")]
    public class CeldasModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo (Name = "Codigo Celda")]
        public string CG_CELDA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Despacho celdas")]
        public string DES_CELDA { get; set; } = "";

        [ColumnaGridViewAtributo(Name = "Código de área")]
        public int CG_AREA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Código de cate")]
        public int CG_CATEOP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Ilimitada")]
        public bool ILIMITADA { get; set; } = false; // bit?)
        [ColumnaGridViewAtributo(Name = "Código de cate")] // cambiar nombre
        public decimal COEFI { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Código de proveedor")]
        public int CG_PROVE { get; set; } = 0;
        //
        [ColumnaGridViewAtributo(Name = "Valor de ")] //cambiar nombre del valor
        public decimal VALOR_AMOR { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Valor de ")] // cambiar nombre del valor
        public decimal VALOR_MERC { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Cantidad de años")] //revisar
        public decimal CANT_ANOS { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Cantidad de unidades")]
        public decimal CANT_UNID { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Rep años")]
        public decimal REP_ANOS { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "M2")]
        public decimal M2 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Energía")]
        public decimal ENERGIA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Combustible")]
        public decimal COMBUST { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Aire comprimido")]
        public decimal AIRE_COMP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Código de tipo de celda")]
        public int CG_TIPOCELDA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Código de depósito")]
        public int CG_DEPOSM { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Código de compañia")]
        public int CG_CIA { get; set; } = 0;
        

    }
}




      