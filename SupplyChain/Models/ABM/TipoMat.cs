using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain
{
    [Table("TipoMat")]
	public class TipoMat
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[ColumnaGridViewAtributo(Name = "Tipo")]
		public string TIPO { get; set; } = "";
		[ColumnaGridViewAtributo(Name = "Codigo Compañia")]
		public int CG_CIA { get; set; } = 0;
		public string USUARIO { get; set; } = "";

	}
}
