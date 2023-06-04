using Microsoft.AspNetCore.Mvc;

namespace SimpleCatching.Controllers
{
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult HandleError() => Problem();
    }
}
