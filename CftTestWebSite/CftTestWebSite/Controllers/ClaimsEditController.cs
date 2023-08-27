using CftTestWebSite.Models;
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

        [Route("Claims/ClaimsEdit/GetClaims")]
        public List<Claim> TestGetClaims()
        {
            List<Claim> claims = new();
            for (int i = 0; i < 50; i++)
            {
                claims.Add(new Claim
                {
                    Id = i, Application = "test", DateEnd = DateTime.Now, Description = "test desc",
                    Email = "asas@gmail.com", Name = "test name"
                });
            }
            for (int i = 51; i < 100; i++)
            {
                claims.Add(new Claim
                {
                    Id = i,
                    Application = "LLLLLL",
                    DateEnd = DateTime.Now,
                    Description = "LLLL desc",
                    Email = "LLL@gmail.com",
                    Name = "LLLLL name"
                });
            }
            return claims;
        }
    }
}
