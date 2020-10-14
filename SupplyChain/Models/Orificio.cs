using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Orificio")]
	public class Orific
	{

		public int Id { get; set; }
		public string Orificio { get; set; }
		public string Area { get; set; }

	}
}
