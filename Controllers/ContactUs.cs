using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCore_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUs : ControllerBase
    {
        // GET: api/<ContactUs>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ContactUs>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContactUs>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContactUs>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactUs>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
