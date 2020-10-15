using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
	[Table("ItemsAbastecimiento")]
	public class ItemsAbastecimiento
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[ColumnaGridViewAtributo(Name = "Codigo Artículo")]
		public string CG_ART { get; set; } = "";
		[ColumnaGridViewAtributo(Name = "Lote")]
		public string LOTE {get;set;} = "";
		[ColumnaGridViewAtributo(Name = "Serie")]
		public string SERIE {get;set;} = "";
		[ColumnaGridViewAtributo(Name = "Despacho")]
		public string DESPACHO {get;set;} = "";
		[ColumnaGridViewAtributo(Name = "Ubicación")]
		public string UBICACION {get;set;} = "";
		[ColumnaGridViewAtributo(Name = "Descripción artículo")]
		public string DES_ART {get;set;} = "";
		[ColumnaGridViewAtributo(Name = "Cantidad")]  //completar nombre
		public decimal CANTPED {get;set;} = 0;
		[ColumnaGridViewAtributo(Name = "Cantidad 2")]//cpompletar nombre
		public decimal CANTENT {get;set;} = 0;
		[ColumnaGridViewAtributo(Name = "Cantidad 3")] // completar nombnre
		public decimal CANTEMP {get;set;} = 0;
		[ColumnaGridViewAtributo(Name = "Stock")] 
		public decimal STOCK {get;set;} = 0;
		[ColumnaGridViewAtributo(Name = "Unidades")]
		public string UNID {get;set;} = "";
		[ColumnaGridViewAtributo(Name = "Código dep")]
		public int CG_DEP {get;set;} = 0;
		[ColumnaGridViewAtributo(Name = "Código de orden")]
		public int CG_ORDEN {get;set;} = 0;
		[ColumnaGridViewAtributo(Name = "Código de orden 2")] // completae nombre
		public int CG_ORDF {get;set;} = 0;
		[ColumnaGridViewAtributo(Name = "Pedido")]
		public int PEDIDO {get;set;} = 0;
		[ColumnaGridViewAtributo(Name = "Obveservación de ítem")] //revisar nombre
		public string OBSERITEM {get;set;} = "";
		[ColumnaGridViewAtributo(Name = "Aviso")]
		public string AVISO {get;set;} = "";
	}
}
