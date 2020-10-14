using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("TipoCelda")]
	public class TipCelda
	{

		public int Cg_tipocelda { get; set; }
		public string Des_tipocelda { get; set; }
		public int  Cg_cia { get; set; }
	}
}
