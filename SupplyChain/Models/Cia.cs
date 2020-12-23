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
        [ColumnaGridViewAtributo(Name = "Descripcion de compañia")]
        public string DES_CIA { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Dominio físico")]
        public string DOM_FISIC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Locación fisica")]
        public string LOC_FISC { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Descripcion Provincia")]
        public string DES_PROV { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Código postal")]
        public string COD_POST { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Descripcion pais")]
        public string DES_PAIS { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Dominio Comercial")]
        public string DOM_COM { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Locación Comercial")]
        public string LOC_COM { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Prefijo")]
        public int PREFIJO { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Telefono")]
        public string TELEFONO { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Cuit")]
        public string CUIT { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Ingresos Brutos")]
        public string IIBB { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Actividad")]
        public string ACTIVIDAD { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Fecha contrato")]
        public DateTime FE_CONTRAT { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha cierre")]
        public DateTime FE_CIERRE { get; set; }
        [ColumnaGridViewAtributo(Name = "AVISO")]
        public string AVISO { get; set; } = "";
        public int CG_CIA { get; set; } = 0;//
        public string USUARIO { get; set; } = "";
    }
}




