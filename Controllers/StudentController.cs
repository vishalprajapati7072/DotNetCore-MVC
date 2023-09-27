using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_MVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            string auth_Token = HttpContext.Request.Cookies["auth-token"];


            // var response = // api/Student/GetStudents along with bearer token = auth_Token

            return View();
        }
    }
}
