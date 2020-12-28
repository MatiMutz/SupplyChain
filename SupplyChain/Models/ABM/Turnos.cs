using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain
{
    [Table("TURNOS")]
    public class Turnos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo Turno")]
        public int CG_TURNO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Turno")]
        public string TURNO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Desde")]
        public DateTime DESDE { get; set; }
        [ColumnaGridViewAtributo(Name = "Hasta")]
        public DateTime HASTA { get; set; }
    }
}
