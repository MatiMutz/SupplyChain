using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Marca")]
	public class Marc
	{

		public int Id { get; set; }
		public string Marca { get; set; }

	}
}
