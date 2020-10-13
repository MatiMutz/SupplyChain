using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("TipoMat")]
	public class TipMat
	{

		public string Tipo { get; set; }
		public int Cg_cia { get; set; }
	
	}
}
