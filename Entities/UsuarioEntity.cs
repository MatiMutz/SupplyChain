using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class UsuarioEntity
    {
        [StringLength(20)]
        public string Usuario { get; set; }
    }
}
