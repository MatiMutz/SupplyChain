﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain
{
    [Table("Scrap")]
    public class Scrap
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo Scrap")]
        public int CG_SCRAP { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Descripcion Scrap")]
        public string DES_SCRAP { get; set; } = "";
        public int CG_CIA { get; set; } = 0;

        public string USUARIO { get; set; } = "";

    }
}
