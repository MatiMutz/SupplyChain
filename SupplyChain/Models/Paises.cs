using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Pais")]
    public class Pais
    {
        [ColumnaGridViewAtributo (Name = "Codigo")]
        public int Codigo { get; set; } = 0;
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Código de País")]
        public int Cg_Pais { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "País")]
        public string Des_Pais { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Mercosur")]
        public bool Mercosur { get; set; } = false;
        [ColumnaGridViewAtributo(Name = "Cuit")]
        public string Cuit { get; set; } = "";
    }
}




      