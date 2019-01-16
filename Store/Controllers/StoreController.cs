using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    [Produces("application/json")]
    [Route("api/store")]
    public class StoreController : Controller
    {
        // GET: api/Store
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "store-value1", "store-value2" };
        }

        // GET: api/Store/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"store-{id}";
        }
        
        // POST: api/Store
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Store/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
