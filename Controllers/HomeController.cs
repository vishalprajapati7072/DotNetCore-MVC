using DotNetCore_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCore_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //eFCodeFirstContext = new EFCodeFirstContext();
            //efdatabaseFirstContext = new EfdatabaseFirstContext();
        }

        public IActionResult Index()
        {
            //eFCodeFirstContext.Employees.Add(new Employee() { });
            //eFCodeFirstContext.SaveChanges();

            //efdatabaseFirstContext.Employees.Add(new Employee() { });
            //efdatabaseFirstContext.SaveChanges();

            ViewBag.Genders = "";

            ViewData["Genders"] = "";

            TempData["Genders"] = "";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}