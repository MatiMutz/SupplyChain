using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain
{
    public class TurnosEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CG_TURNO { get; set; }
        [StringLength(1)]
        public string TURNO { get; set; }
        [StringLength(1)]
        public string DESDE { get; set; }
        [StringLength(1)]
        public string HASTA { get; set; }
    }
}
