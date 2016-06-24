using Microsoft.AspNetCore.Mvc;

namespace Trivia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aurelia()
        {
            return View();
        }

        public IActionResult React()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
