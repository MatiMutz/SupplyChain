using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Cia")]
    public class Cia
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Código de compañía")]
        public int CG_CIA { get; set; } = 0;
        [ColumnaGridViewAtributo (Name = "Despacho de compañia")]
        public string DES_CIA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Dominio físico")]
        public string DOM_FISIC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Locación fisica")]
        public string LOC_FISC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Despacho Provincia")]
        public string DES_PROV { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Código postal")]
        public string COD_POST { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Despacho pais")]
        public string DES_PAIS { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Dominio ")]
        public string DOM_COM { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Locación ")]
        public string LOC_COM { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Prefijo")]
        public int PREFIJO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "TELEFONO ")]
        public string TELEFONO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "CUIT ")]
        public string CUIT { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "IIBB ")]
        public string IIBB { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "ACTIVIDAD")]
        public string ACTIVIDAD { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Fecha contrato")]
        public DateTime FE_CONTRAT { get; set; } 
            [ColumnaGridViewAtributo(Name = "Fecha cierre")]
        public DateTime FE_CIERRE { get; set; } 
        [ColumnaGridViewAtributo(Name = "AVISO")]
        public string AVISO { get; set; } = "";

    }
}




      