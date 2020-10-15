using SupplyChain.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        public int CG_CLI { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Nombre del cliente")]
        public string DES_CLI { get; set; }
        [ColumnaGridViewAtributo(Name = "Onservaciones")]
        public string OBSERVACIONES { get; set; }
        [ColumnaGridViewAtributo(Name = "Dirección")]
        public string DIRECC { get; set; }
        [ColumnaGridViewAtributo(Name = "Localidad")]
        public string LOCALIDAD { get; set; }
        [ColumnaGridViewAtributo(Name = "Codigo postal")]
        public int? CG_POST { get; set; }
        [ColumnaGridViewAtributo(Name = "Provincia")]
        public int? CG_PROV { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre provincia")]
        public string DES_PROV { get; set; }
        [ColumnaGridViewAtributo(Name = "Pais")]
        public int? CG_PAIS { get; set; }
        [ColumnaGridViewAtributo(Name = "Condición fiscal")]
        public string CG_COND { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha alta")]
        public DateTime FE_ALTA { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre del contacto")]
        public string CONTACTO { get; set; }
        [ColumnaGridViewAtributo(Name = "Teléfono")]
        public string TELEFONO { get; set; }
        [ColumnaGridViewAtributo(Name = "FAX")]
        public string FAX { get; set; }
        [ColumnaGridViewAtributo(Name = "Email")]
        public string EMAIL { get; set; }
        [ColumnaGridViewAtributo(Name = "Saldo")]
        public decimal? SALDO { get; set; }
        [ColumnaGridViewAtributo(Name = "Crédito")]
        public decimal? CREDITO { get; set; }
        [ColumnaGridViewAtributo(Name = "Activo")]
        public string ACTIVO { get; set; }
        [ColumnaGridViewAtributo(Name = "CUIT")]
        public string CUIT { get; set; }
        [ColumnaGridViewAtributo(Name = "IIBB")]
        public string BRUTOS { get; set; }
        [ColumnaGridViewAtributo(Name = "Convenio")]
        public int CM { get; set; }
        [ColumnaGridViewAtributo(Name = "Bonificación")]
        public decimal? BONIFIC { get; set; }
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Dirección de entrega")]
        public string ENTREGA { get; set; }
        [ColumnaGridViewAtributo(Name = "Código postal alfanumerico")]
        public string CG_POSTA { get; set; }
        [ColumnaGridViewAtributo(Name = "Porc.IVA especial")]
        public decimal? PORCIVAESP { get; set; }
        [ColumnaGridViewAtributo(Name = "LEY19640")]
        public int? LEY19640 { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }
    }
}
