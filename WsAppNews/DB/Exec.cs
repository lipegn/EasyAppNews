using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsAppNews.DB
{
    public static class Exec
    {
        public static EasyAppNewsEntities RetornaDb()
        {
            try
            {
                return new EasyAppNewsEntities(new dllAcessoWeb.clsAcessoBanco("EasyAppNews").RetornaConexao());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}