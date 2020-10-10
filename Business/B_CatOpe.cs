using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities;
using DataAccess;

namespace Business
{
    public class B_CatOpe
    {
        public static List<CatOpeEntity> CategoriaList()
        {
            using (var db = new OperariosContext())
            {
                return db.CateOperarios.ToList();
            }
        }
    }
}
