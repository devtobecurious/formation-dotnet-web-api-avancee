using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomConstraints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WookieeController : ControllerBase
    {
        [HttpGet("wookiees/speak/{language:wook}")]
        public IActionResult Get(string language)
        {
            return this.Ok(language);
        }
    }
}
