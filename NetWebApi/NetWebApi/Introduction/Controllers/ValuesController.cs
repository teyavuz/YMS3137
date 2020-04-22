using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Introduction.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<string> sampleProducts = new List<string>
        {
            "Chai",
            "Chang",
            "Ikura"
        };

        // GET api/values
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return sampleProducts;
        }

        // GET api/values/5
        public string Get(int id)
        {
            //return "value";
            return sampleProducts[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            sampleProducts.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            sampleProducts[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            sampleProducts.Remove(sampleProducts[id]);
        }
    }
}
