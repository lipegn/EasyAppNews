using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WsAppNews.Controllers
{
    public class EasyAppNewsController : ApiController
    {
        // GET api/easyappnews
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
