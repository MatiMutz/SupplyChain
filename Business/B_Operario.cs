using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities;
using DataAccess;

namespace Business
{
    public class B_Operario
    {
        public static List<OperarioEntity> OperarioList()
        {
            using (var db = new OperariosContext())
            {
                return db.Operario.ToList();
            }
        }
        public static OperarioEntity OperarioById(string id)
        {
            using (var db = new OperariosContext())
            {
                return db.Operario.ToList().LastOrDefault(p => p.CG_OPER.ToString() == id);
            }
        }
        public static void CreateOperario(OperarioEntity oOperario)
        {
            using (var db = new OperariosContext())
            {
                db.Operario.Add(oOperario);
                db.SaveChanges();
            }
        }
        public static void CreateOrUpdateOperario(OperarioEntity oOperario)
        {
            try
            {
                using (var db = new OperariosContext())
                {
                    db.Operario.Add(oOperario);
                    db.SaveChanges();
                }
            }
            catch
            {
                using (var db = new OperariosContext())
                {
                    db.Operario.Update(oOperario);
                    db.SaveChanges();
                }
            }


        }
        public static void UpdateOperario(OperarioEntity oOperario)
        {
            using (var db = new OperariosContext())
            {
                db.Operario.Update(oOperario);
                db.SaveChanges();
            }
        }
        public static void RemoveOperario(OperarioEntity oOperario)
        {
            using (var db = new OperariosContext())
            {
                db.Operario.Remove(oOperario);
                db.SaveChanges();
            }
        }
    }
}
