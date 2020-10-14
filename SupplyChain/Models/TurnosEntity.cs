using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain
{
    [Table("TURNOS")]
    public class TurnosEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CG_TURNO { get; set; }
        [StringLength(1)]
        public string TURNO { get; set; }
        [StringLength(1)]
        public DateTime DESDE { get; set; }
        
        public DateTime HASTA { get; set; }
    }
}
