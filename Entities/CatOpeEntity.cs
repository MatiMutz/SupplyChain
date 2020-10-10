using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CatOpeEntity
    {
        [Key]
        [StringLength(20)]
        public string CG_CATEOP { get; set; }
        [StringLength(500)]
        public string DES_CATEOP { get; set; }
        public decimal VALOR_HORA { get; set; }
        [StringLength(20)]
        public string MONEDA { get; set; }
        public int CG_CIA { get; set; }
        [StringLength(20)]
        public string USUARIO { get; set; }

    }
}
