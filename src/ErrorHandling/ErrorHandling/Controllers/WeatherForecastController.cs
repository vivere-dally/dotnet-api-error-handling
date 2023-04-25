using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<WeatherForecast> Get()
        {
            var forecast = new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };

            if (new DateTimeOffset(forecast.Date).ToUnixTimeMilliseconds() % 2 == 0)
            {
                return new ObjectResult(new Exception("unlucky :p"))
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }

            return Ok(forecast);
        }
    }
}