using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("CalendarioFestivos")]
    public class CalendarioFestivos
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Registro")]
        public decimal Registro { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Guid")]
        public int Guid { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Fecha")]
        public DateTime? Fecha { get; set; }
        [ColumnaGridViewAtributo(Name = "Descripcion")]
        public string Descripcion { get; set; } = "";
    }
}
