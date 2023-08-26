using Microsoft.AspNetCore.Mvc;

namespace CftTestWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
