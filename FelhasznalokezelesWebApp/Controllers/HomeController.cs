using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FelhasznalokezelesWebApp.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        [Authorize(Roles = "User, Editor, Admin")]
        [HttpGet]
        [Route("/vmi")]
        public ActionResult<string> Vmi()
        {
            return Ok("Valami van.");
        }
    }
}
