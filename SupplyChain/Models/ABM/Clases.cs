using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain
{
    [Table("Clases")]
    public class Clase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo Clase")]
        public int CG_CLASE { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion Clase")]
        public string DES_CLASE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo compañía")]
        public int CG_CIA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string USUARIO { get; set; } = "";
    }
}
