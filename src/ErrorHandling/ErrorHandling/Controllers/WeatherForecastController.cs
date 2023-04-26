using System.Net.Mime;

using ErrorHandling.Middleware;
using ErrorHandling.Services;

using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [ArgumentExceptionFilter]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly TemperatureService _temperatureService;

        public WeatherForecastController(TemperatureService temperatureService)
        {
            _temperatureService = temperatureService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(WeatherForecast))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(string))]
        public WeatherForecast Get([FromQuery] int l = -20, [FromQuery] int r = 55)
        {
            return new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = _temperatureService.GetTemperature(l, r),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            };
        }
    }
}