using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Clases")]
    public class Clase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo Clase")]
        public int CG_CLASE { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion Clase")]
        public string DES_CLASE { get; set; } = "";
    }
}
