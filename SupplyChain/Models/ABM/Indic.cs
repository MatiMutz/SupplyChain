using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain
{
    [Table("Indic")]
    public class Indic
    {
        [ColumnaGridViewAtributo(Name = "Descripcion ind")] // revisar nombre 
        public string DES_IND { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "va indic")] // REVISAR NOMBRE
        public decimal VA_INDIC { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "va compra")] // REVISAR NOMBRE
        public decimal VA_COMPRA { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Fecha")] // revisar nombre 
        public DateTime FE_INDIC { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo (Name = "Registro")] 
        public int REGISTRO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "CODIGO CIA")] // REVISAR NOMBRE
        public int CG_CIA { get; set; } = 0;
        public string USUARIO { get; set; } = "";
    }
}




      