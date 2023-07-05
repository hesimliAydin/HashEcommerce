using Ecommerce.WebUI.ExtensionMethods;
using Ecommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebUI.Controllers
{
    public class SessionController : Controller
    {
        private IHttpContextAccessor _contextAccessor;

        public SessionController(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public IActionResult Index()
        {
            //var age = _contextAccessor.HttpContext.Session.GetInt32("age");
            //var name = _contextAccessor.HttpContext.Session.GetString("name");
            //return age + " " + name;

            var student = _contextAccessor.HttpContext.Session.GetObject<StudentTest>("student");
            return Json(student);
        }

        public string Set()
        {
            _contextAccessor.HttpContext.Session.SetInt32("age", 24);
            _contextAccessor.HttpContext.Session.SetString("name", "Aydin");

            var student = new StudentTest
            {
                Id=111,
                Name="Aydin",
                Surname="Hesimli",
                Age=20
            };

            _contextAccessor.HttpContext.Session.SetObject("student", student);

            return "Data succesfuly";

        }
    }
}
