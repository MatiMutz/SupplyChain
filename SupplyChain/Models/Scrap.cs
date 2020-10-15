using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Scrap")]
    public class Scraps
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo Scrap")]
        public int CG_SCRAP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion Scrap")]
        public string DES_SCRAP { get; set; } = "";
    }
}
