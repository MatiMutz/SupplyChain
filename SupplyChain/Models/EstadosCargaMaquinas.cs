using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("EstadosCargaMaquinas")]
	public class EstadosCargaMaquinas
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[ColumnaGridViewAtributo(Name = "Codigo estado")]
		public int CG_ESTADO { get; set; } = 0;
		[ColumnaGridViewAtributo(Name = "Descripcion de estado")]
		public string DES_TIPOAREA { get; set; } = "";
		[ColumnaGridViewAtributo(Name = "R")]
		public int R { get; set; } = 0;
		[ColumnaGridViewAtributo(Name = "G")]
		public int G { get; set; } = 0;
		[ColumnaGridViewAtributo(Name = "B")]
		public int B { get; set; } = 0;
	}
}
