using Microsoft.AspNetCore.Mvc;

namespace WorkingWithErrors.Controllers
{
    public class ErrorController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("/error")]
        [HttpGet]
        public IActionResult HandleError() => Problem();
    }
}
