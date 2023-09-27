using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_MVC.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {

            // API call
            // var response = // Auth/GetToken?userName=userName&password=password

            // response.token

            HttpContext.Response.Cookies.Append("auth-token", "response.token");

            return View();
        }
    }
}
