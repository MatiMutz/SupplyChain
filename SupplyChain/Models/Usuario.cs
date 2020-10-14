using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SupplyChain.Shared.Models
{
    public class User
    {
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string Usuario { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Codigo Tipo Usuario")]
        public int Cg_TipoUsu { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Nombre")]
        public string Nombre { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Email")]
        public string Email { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Telefono Oficina")]
        public string Tel_Of { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Telefono Movil")]
        public string Tel_Mov { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Telefono Particular")]
        public string Tel_Part { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Contraseña")]
        public string Contras { get; set; } = "";
        [ColumnaGridViewAtributo(Name = "Derechos")]
        public int Derechos { get; set; } = 0;
        [ColumnaGridViewAtributo(Name = "Codigo compañia")]
        public int Cg_Cia { get; set; } = 0;
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Identificador")]
        public int Id { get; set; } = 0;
    }
}
