using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Vende")]
    public class Vende
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo (Name = "Codigo Venta")]
        public int CG_VEN { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion venta")]
        public string DES_VEN { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "usuario")]
        public string USUARIO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Código de compañía")]
        public int CG_CIA { get; set; } = 0;
    }
}




      