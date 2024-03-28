using Microsoft.AspNetCore.Mvc;

namespace Sana09.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Fict()
        {
            return View();
        }
        public IActionResult DeanFict()
        {
            return View();
        }
    }
}
