using DocumentFormat.OpenXml.Spreadsheet;
using GroupBProject.DB;
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
        [Route("Getdetails")]
        public IEnumerable<Employee> Getdetails()
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            var result= dbContext.Employees.ToList();
            return result;
        }

        // GET api/<EmployeeController>/5
        [HttpPost]
        [Route("SaveEmployee")]
        public Employee SaveEmployee(Employee newEmployee)
        {
            try
            {
                //this.helper.EmployeeFileWrite(newEmployee);

                EmployeeDBContext dbContext = new EmployeeDBContext();
                //Add a row in table
                dbContext.Add(newEmployee);
                dbContext.SaveChanges();

                return newEmployee;

            }
            catch (Exception)
            {

                throw;
            }
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
