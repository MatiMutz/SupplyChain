using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Protab")]
    public class Protab
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "PROCESO")]
        public string PROCESO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Descripcion Parada")]
        public string DESCRIP { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "OBSERVAC")]
        public string OBSERVAC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo compañia")]
        public int CG_CIA { get; set; } = 0;
        public string USUARIO { get; set; }
    }
}
