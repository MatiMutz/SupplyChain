using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Orificio")]
	public class Orificio
	{

		public int ID { get; set; }
		public string ORIFICIO { get; set; }
		public string AREA { get; set; }

	}
}
