using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Modelo")]
	public class Model
	{

		public int Id { get; set; }
		public string Modelo { get; set; }

	}
}
