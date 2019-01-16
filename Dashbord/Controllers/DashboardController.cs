using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dashbord.Controllers
{
    [Produces("application/json")]
    [Route("api/dashboard")]
    public class DashboardController : Controller
    {
        // GET: api/Dashboard
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "dashboard-value1", "dashboard-value2" };
        }

        // GET: api/Dashboard/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"dashboard-{id}";
        }
        
        // POST: api/Dashboard
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Dashboard/5
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
