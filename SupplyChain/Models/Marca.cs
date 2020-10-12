using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Marca")]
	public class Marca
	{

		public int ID { get; set; }
		public string MARCA { get; set; }

	}
}
