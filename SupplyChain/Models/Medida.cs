using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Medida")]
	public class Medida
	{

		public int ID { get; set; }
		public string CODIGO { get; set; }
		public string MEDIDA { get; set; }

	}
}
