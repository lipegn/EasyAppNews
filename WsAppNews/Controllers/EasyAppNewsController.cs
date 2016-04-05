using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WsAppNews.DB;
using models = ModelsAppNews;

namespace WsAppNews.Controllers
{
    public class EasyAppNewsController : ApiController
    {
        // GET api/easyappnews
        public IEnumerable<models.tblBloco> GetBlocos()
        {
            try
            {
                List<models.tblBloco> listaBlocos = new List<models.tblBloco>();
                models.tblBloco bloco;
                models.tblTipoBloco tipoBloco;
                using (EasyAppNewsEntities db = Exec.RetornaDb())
                {
                    foreach (var item in db.tblBloco.ToList())
                    {
                        bloco = new models.tblBloco();
                        bloco = (models.tblBloco)Exec.CopiarValoresClasse(bloco, item);

                        tipoBloco = new models.tblTipoBloco();
                        bloco.tblTipoBloco = (models.tblTipoBloco)Exec.CopiarValoresClasse(tipoBloco, item.tblTipoBloco);

                        listaBlocos.Add(bloco);
                    }

                    return listaBlocos;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET api/easyappnews/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/easyappnews
        public void Post([FromBody]string value)
        {
        }

        // PUT api/easyappnews/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/easyappnews/5
        public void Delete(int id)
        {
        }
    }
}
