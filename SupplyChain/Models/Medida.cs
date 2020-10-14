using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Medida")]
	public class Medid
	{

		public int Id { get; set; }
		public string Codigo { get; set; }
		public string Medida { get; set; }

	}
}
