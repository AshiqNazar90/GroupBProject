using Microsoft.AspNetCore.Mvc;
using RestSharp;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroupBProject.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        // GET: api/<WeatherController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WeatherController>/5
        [HttpGet]
        [Route("GetWeather")]
        public string GetWeather()
        {

            var client = new RestClient("http://api.weatherapi.com/v1/current.json?key=d90506ffda3441ba9eb41606220702&q=London&aqi=yes");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        // POST api/<WeatherController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WeatherController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WeatherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
