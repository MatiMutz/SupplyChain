using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class OperarioEntity
    {
        [Key]
        public int CG_OPER { get; set; }
        [StringLength(500)]
        public string DES_OPER { get; set; }
        public int CG_TURNO { get; set; }
        public decimal RENDIM { get; set; }

        public DateTime? FE_FINAL { get; set; }

        public int HS_FINAL { get; set; }
        [StringLength(20)]
        public string CG_CATEOP { get; set; }
        public decimal VALOR_HORA { get; set; }
        [StringLength(20)]
        public string MONEDA { get; set; }
        public bool ACTIVO { get; set; }
        public int CG_CIA { get; set; }
        [StringLength(20)]
        public string USUARIO { get; set; }
    }
}
