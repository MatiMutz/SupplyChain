using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities;
using DataAccess;

namespace Business
{
    public class B_Cliente
    {
        public static List<ClienteEntity> ClienteList()
        {
            using (var db = new OperariosContext())
            {
                return db.Cliente.ToList();
            }
        }
    }
}
