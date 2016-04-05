using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WsAppNews.DB
{
    public static class Exec
    {
        public static EasyAppNewsEntities RetornaDb()
        {
            try
            {
                EasyAppNewsEntities db = new EasyAppNewsEntities();
                db.Database.Connection.ConnectionString = new dllAcessoWeb.clsAcessoBanco("EasyAppNews").RetornaConexao();

                return db;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Object CopiarValoresClasse(Object val1,Object val2)
        {
            try
            {
                Object valorObj;
                if (val2 == null)
                    return val1;
                foreach (PropertyInfo item in val2.GetType().GetProperties())
                {
                    if (!item.Name.Contains("tbl"))
                    {
                        valorObj = item.GetValue(val2, null);
                        val1.GetType().GetProperty(item.Name).SetValue(val1, valorObj, null);
                    }
                }
                return val1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}