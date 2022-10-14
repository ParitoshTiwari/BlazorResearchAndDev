using Microsoft.AspNetCore.Mvc;

namespace APITesting.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        [HttpGet]
        public async Task GetCountries()
        {
            HttpClient client = new HttpClient();
            var httpClient = await client.GetAsync("https://restcountries.com/v2/all").ConfigureAwait(false);
            httpClient.ToString();
        }
    }
}