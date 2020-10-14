using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    [Table("Pedcli")]
    public class Pedcli
    {
        public int PEDIDO { get; set; }
        public string CG_ESTADO { get; set; }
        public string FE_PED { get; set; }
        public string CG_ART { get; set; }
        public string DES_ART { get; set; }
        public string LOTE { get; set; }
        public string DESPACHO { get; set; }
        public string SERIE { get; set; }
        public decimal CANTPED { get; set; }
        public string UNID { get; set; }
        public decimal CANTENT { get; set; }
        public decimal IMPORTE1 { get; set; }
        public decimal? IMPORTE2 { get; set; }
        public decimal? IMPORTE3 { get; set; }
        public decimal? IMPORTE4 { get; set; }
        public decimal IMPORTE6 { get; set; }
        public decimal DESCUENTO { get; set; }
        public decimal IVA { get; set; }
        public DateTime? ENTRPREV { get; set; }
        public DateTime? ENTRREAL { get; set; }
        public string REMITO { get; set; }
        public string FACTURA { get; set; }
        public decimal CG_CLI { get; set; }
        public string DES_CLI { get; set; }
        public int CG_VEN { get; set; }
        public string ORCO { get; set; }
        public decimal BONIFIC { get; set; }
        public string DIRENT { get; set; }
        public string LOCALIDAD { get; set; }
        public int CG_POST { get; set; }
        public int CG_PROV { get; set; }
        public string LISTA { get; set; }
        public DateTime? FE_VENC { get; set; }
        public decimal NUMOCI { get; set; }
        public string MONEDA { get; set; }
        public DateTime? FE_INDIC { get; set; }
        public decimal VA_INDIC { get; set; }
        public string OBSERITEM { get; set; }
        public string CAMPOCOM1 { get; set; }
        public string CAMPOCOM2 { get; set; }
        public string CAMPOCOM3 { get; set; }
        public string CAMPOCOM4 { get; set; }
        public string CAMPOCOM5 { get; set; }
        public string CAMPOCOM6 { get; set; }
        public string OBS1 { get; set; }
        public string OBS2 { get; set; }
        public string OBS3 { get; set; }
        public string OBS4 { get; set; }
        public decimal OCOMPRA { get; set; }
        public string CG_POSTA { get; set; }
        public string DIRECC { get; set; }
        public string USUARIO { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int REGISTRO { get; set; }
        public DateTime FE_REG { get; set; }
        public int CG_CIA { get; set; }
    }
}
