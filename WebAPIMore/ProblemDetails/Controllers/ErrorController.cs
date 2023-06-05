using Microsoft.AspNetCore.Mvc;

namespace SimpleCatching.Controllers
{
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        [Route("/error")]
        public IActionResult HandleError() => Problem();
    }
}
