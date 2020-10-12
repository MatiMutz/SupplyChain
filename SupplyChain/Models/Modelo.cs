using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Modelo")]
	public class Modelo
	{

		public int ID { get; set; }
		public string MODELO { get; set; }

	}
}
