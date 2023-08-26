using Microsoft.AspNetCore.Mvc;

namespace CftTestWebSite.Controllers
{
    public class ClaimsCreationController : Controller
    {
        [Route("Claims/ClaimsCreation")]
        public IActionResult ClaimsCreation()
        {
            return View();
        }

        [Route("Claims/ClaimsCreation/Test")]
        public ContentResult Test()
        {
            return Content("Test");
        }
    }
}
