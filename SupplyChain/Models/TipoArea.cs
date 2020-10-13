using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("TipoArea")]
	public class TipArea
	{

		public int Cg_tipoarea { get; set; }
		public string Des_tipoarea { get; set; }

	}
}
