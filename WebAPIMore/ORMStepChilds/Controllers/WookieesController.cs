using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ORMDecouverte.Models;

namespace ORMStepChilds.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WookieesController : ControllerBase
    {
        private readonly GameContext context;

        public WookieesController(GameContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return this.Ok(this.context.Wookies.AsNoTracking().Include(item => item.Roles).Include(item => item.Weapon).ToList());
        }
    }
}
