using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteTelegramException.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        //endpoint com erro 
        [HttpGet("Division/{number}")]
        public IActionResult Division(int number)
        {
            var result = number / 0;
            return Ok(result);
        }

    }
}
