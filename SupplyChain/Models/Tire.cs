using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text;

namespace SupplyChain.Shared.Models
{

    [Table("Tire")]
    public class Tire
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "CG_TIRE")]
        public int CG_TIRE { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "DES_TIRE")]
        public string DES_TIRE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CRGO")]
        public string CRGO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CG_DEP")]
        public string CG_DEP { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CG_DEP1")]
        public string CG_DEP1 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CG_CIA")]
        public string CG_CIA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "PVENTAREM")]
        public string PVENTAREM { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "OBLIREMEXT")]
        public string OBLIREMEXT { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPO")]
        public string TIPO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "REQCONV")]
        public string REQCONV { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "REPORTE1")]
        public string REPORTE1 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "REPORTE2")]
        public string REPORTE2 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "REPORTE3")]
        public string REPORTE3 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "REPORTE4")]
        public string REPORTE4 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPOINS1")]
        public string TIPOINS1 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPOINS3")]
        public string TIPOINS3 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPOINS4")]
        public string TIPOINS4 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPOINS99")]
        public string TIPOINS99 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPOINS10")]
        public string TIPOINS10 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPOINS11")]
        public string TIPOINS11 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPOINS12")]
        public string TIPOINS12 { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "PERMODFE")]
        public string PERMODFE { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "ALTANOOF")]
        public string ALTANOOF { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "REQCAMP")]
        public string REQCAMP { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "REMSALMAN")]
        public string REMSALMAN { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "ALTANOOC")]
        public string ALTANOOC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "TIPOINS13")]
        public string TIPOINS13 { get; set; } = "";

    }
}
