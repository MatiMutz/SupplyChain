using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("genera")]
    public class Genera
    {
        [ColumnaGridViewAtributo(Name = "Codigo Compañia")]
        public int CG_CIA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "CAMP3")]
        public string CAMP3 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Valor 1")]
        public decimal VALOR1 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Valor 2")]
        public decimal VALOR2 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Punto de Venta")]
        public string PUNTO_VENTA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Maximo Valor")]
        public decimal MAXVALOR { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Ultimo Cambio")]
        public decimal ULTIMOCAMBIO { get; set; } = 0;
    }
}
