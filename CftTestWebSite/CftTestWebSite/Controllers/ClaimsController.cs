using Microsoft.AspNetCore.Mvc;

namespace CftTestWebSite.Controllers
{
    public class ClaimsController : Controller
    {
        [Route("Claims")]
        public IActionResult Claims()
        {
            return View();
        }
    }
}
