﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Sobrepresion")]
    public class Sobrepresion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Id")]
        public int Id { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion")]
        public string Descripcion { get; set; } = "";
    }
}
