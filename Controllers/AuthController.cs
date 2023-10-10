using DotNetCore_MVC.Helper;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace DotNetCore_MVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly IEmployee _employee;

        public AuthController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {

            string token = TokenManager.GenerateToken(userName, password);

            return View();
        }
    }
}
