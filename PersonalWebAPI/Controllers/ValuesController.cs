using PersonalWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PersonalWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        LocacaoDb locacaoDB = new LocacaoDb();
        // GET api/values
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<Carro> Get()
        {
            return locacaoDB.Carros.ToList<Carro>();
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET api/values/5
        public string Get(int id)
        {
            return new string[] { "café", "cerveja litrão" }[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
