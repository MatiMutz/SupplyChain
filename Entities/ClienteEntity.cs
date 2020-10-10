using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ClienteEntity
    {
        [Key]
        public int CG_CLI { get; set; }
        [StringLength(500)]
        public string DES_CLI { get; set; }
    }
}
