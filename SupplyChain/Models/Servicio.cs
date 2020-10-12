using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    public class Servicio
    {
        [StringLength(255)]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PEDIDO { get; set; }
        public DateTime? FECHA { get; set; }
        public string CLIENTE { get; set; }
        [StringLength(255)]
        public string PLANTA { get; set; }
        [StringLength(255)]
        public string OCOMPRA { get; set; }
        [StringLength(255)]
        public string REMITOREC { get; set; }
        [StringLength(255)]
        public string REMITO { get; set; }
        [StringLength(255)]
        public string IDENTIFICACION { get; set; }
        [StringLength(255)]
        public string NSERIE { get; set; }
        [StringLength(255)]
        public string MARCA { get; set; }
        [StringLength(255)]
        public string MODELO { get; set; }
        [StringLength(255)]
        public string MEDIDA { get; set; }
        [StringLength(255)]
        public string SERIE { get; set; }
        [StringLength(255)]
        public string ORIFICIO { get; set; }
        [StringLength(255)]
        public string AREA { get; set; }
        [StringLength(255)]
        public string FLUIDO { get; set; }
        [StringLength(255)]
        public string AÑO { get; set; }
        [StringLength(255)]
        public string PRESION { get; set; }
        [StringLength(255)]
        public string TEMP { get; set; }
        [StringLength(255)]
        public string PRESIONBANCO { get; set; }
        [StringLength(255)]
        public string SOBREPRESION { get; set; }
        [StringLength(255)]
        public string CONTRAPRESION { get; set; }
        [StringLength(255)]
        public string TIPO { get; set; }
        [StringLength(255)]
        public string RESORTE { get; set; }
        [StringLength(255)]
        public string SERVICIO { get; set; }
        [StringLength(255)]
        public string ENSRECEP { get; set; }
        [StringLength(255)]
        public string ESTADO { get; set; }
        [StringLength(255)]
        public string PRESIONRECEP { get; set; }
        [StringLength(255)]
        public string FUGAS { get; set; }
        [StringLength(255)]
        public string PRESIONFUGA { get; set; }
        [StringLength(255)]
        public string CAMBIOPRESION { get; set; }
        [StringLength(255)]
        public string PRESIONSOLIC { get; set; }
        [StringLength(255)]
        public string CAMBIOREPUESTO { get; set; }
        [StringLength(255)]
        public string CODRESORTE { get; set; }
        [StringLength(255)]
        public string REPUESTOS { get; set; }
        [StringLength(8000)]
        public string TRABAJOSEFEC { get; set; }
        [StringLength(255)]
        public string TRABAJOSACCES { get; set; }
        [StringLength(255)]
        public string MANOMETRO { get; set; }
        [StringLength(255)]
        public string FECMANTANT { get; set; }
        [StringLength(255)]
        public string PEDIDOANT { get; set; }
        [StringLength(255)]
        public string ENSAYOCONTRAP { get; set; }
        [StringLength(255)]
        public string RESP { get; set; }
        [StringLength(255)]
        public string CONTROLO { get; set; }
        [StringLength(255)]
        public string POP { get; set; }
        [StringLength(255)]
        public string RESPTECNICO { get; set; }
        [StringLength(255)]
        public string OPDS { get; set; }
        [StringLength(255)]
        public string ACTA { get; set; }
        [StringLength(255)]
        public string PRESENCAINSPEC { get; set; }
        [StringLength(500)]
        public string DESCARTICULO { get; set; }
        [StringLength(8000)]
        public string OBSERV { get; set; }
    }
}
