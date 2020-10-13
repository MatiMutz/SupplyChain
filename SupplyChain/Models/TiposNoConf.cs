using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("TiposNoConf")]
	public class TipNoConf
	{

		public int Cg_TipoNc { get; set; }
		public string Des_TipoNc { get; set; }
		public int  Cg_cia { get; set; }
	}
}
