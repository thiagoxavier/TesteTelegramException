using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Teste3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        //Teste que gerará erro
        [HttpGet]
        public IActionResult Get(int n = 1)
        {
            var restu = n / 0;
            return Ok();
        }
    }
}
