using DocumentFormat.OpenXml.Spreadsheet;
using GroupBProject.Model;
using GroupBProject.Utill;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupBProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IHelper helper;

        public EmployeeController(IHelper helper)
        {
            this.helper = helper;
        }

        //GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeeController>/5
        [HttpGet]
        [Route("GetEmployee")]
        public string Get(int id)
        {
            this.helper.EmployeeFileWrite();
            return "value";
        }


        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
