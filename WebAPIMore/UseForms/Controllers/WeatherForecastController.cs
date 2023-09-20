using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace UseForms.Controllers
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

        //[HttpPost]
        //public IActionResult Post(BindingClass item)
        //{
        //    return this.Ok(item);
        //}

        [HttpPost]
        public IActionResult Post(Wookiee item)
        {
            if (ModelState.IsValid)
            {

            }

            return this.Ok(item);
        }

        [BindProperty(Name = "testOne", SupportsGet = false)]
        public int TestOne { get; set; }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }

    public class Wookiee
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public string? Surname { get; set; }
    }

    public class BindingClass
    {
        [FromHeader(Name = "Accept")]
        public string Accept { get; set; } = "";

        [FromQuery(Name = "filter")]
        public string? Filter { get; set; }
    }
}