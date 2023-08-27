using Microsoft.AspNetCore.Mvc;

namespace CftTestWebSite.Controllers
{
    public class ClaimsEditController : Controller
    {
        [Route("Claims/ClaimsEdit")]
        public IActionResult ClaimsEdit()
        {
            return View();
        }
    }
}
