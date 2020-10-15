using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("IVA")]
    public class Iva
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo (Name = "Codigo COND")] //Revisr nombre
        public string CG_COND { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CF IVA 1")] // REVISAR NOMBRE
        public decimal CF_IVA1 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "CF IVA 2")] // REVISAR NOMBRE
        public decimal CF_IVA2 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "CF IVA 3")] // REVISAR NOMBRE
        public decimal CF_IVA3 { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Código")]
        public int CODIGO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Letra")] 
        public string LETRA { get; set; } = "";
    }
}




      