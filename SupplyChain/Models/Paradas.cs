using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Paradas")]
    public class Paradas
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo Parada")]
        public int CP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion Parada")]
        public string DESCRIP { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo compañia")]
        public int CG_CIA { get; set; } = 0;
    }
}
