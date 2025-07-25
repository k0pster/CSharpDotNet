using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace controller_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimateController : ControllerBase
    {
        // GET: api/<ClimateController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ClimateController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClimateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClimateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClimateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
