using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{

    [Table("Prod")]
    public class ProdPage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CG_PROD { get; set; }
        [StringLength(500)]
        public string DES_PROD { get; set; }
        public int CG_ORDEN { get; set; }
        public string TIPO { get; set; }
        public int CG_CLAS { get; set; }
        public string UNID { get; set; }
        public decimal? CG_DENSEG { get; set; }
        public string UNIDSEG { get; set; }
        public decimal PESO { get; set; }
        public string UNIDPESO { get; set; }
        public string ESPECIF { get; set; }
        public string NORMA { get; set; }
        public int EXIGEDESPACHO { get; set; }
        public int EXIGELOTE { get; set; }
        public int EXIGESERIE { get; set; }
        public int EXIGEOA { get; set; }
        public decimal STOCKMIN { get; set; }
        public decimal LOPTIMO { get; set; }
        public int CG_AREA { get; set; }
        public int CG_LINEA { get; set; }
        public string ACTIVO { get; set; }
        public decimal TIEMPOFAB { get; set; }
        public decimal COSTO { get; set; }
        public decimal COSTOTER { get; set; }
        public string MONEDA { get; set; }
        public string CG_CELDA { get; set; }
        public int CG_TIPOAREA { get; set; }
        public decimal CG_CUENT1 { get; set; }
        public decimal UNIDEQUI { get; set; }
        public decimal COSTOUC { get; set; }
        public string MONEDAUC { get; set; }
        public decimal COSTOUC1 { get; set; }
        public DateTime? FE_UC { get; set; }
        public string USUARIO { get; set; }
        public DateTime? FE_REG { get; set; }
        public int CG_CIA{ get; set; }






    }
}
