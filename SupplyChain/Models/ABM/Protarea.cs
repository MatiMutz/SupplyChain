using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain
{
    [Table("ProTarea")]
    public class Protarea
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "TAREAPROC")]
        public string TAREAPROC { get; set; } = "";
        
        [ColumnaGridViewAtributo(Name = "Descripcion")]
        public string DESCRIP { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBSERVAC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "codigo de compañia")]
        public int CG_CIA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string USUARIO { get; set; } = "";
        
    }
}
