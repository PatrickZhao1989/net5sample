using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace net5sample.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class HelloWorldController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> _logger;

		public HelloWorldController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Get(string name)
		{
			_logger.LogError($"Hello World {name} in controller");
			return Ok($"Hello {name}");
		}
	}
}
