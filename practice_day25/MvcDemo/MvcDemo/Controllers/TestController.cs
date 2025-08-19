using Microsoft.AspNetCore.Mvc;

namespace MvcDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Course()
        {
            return View();
        }
        public IActionResult LunchTime()
        {
            return View();
        }
    }
}
