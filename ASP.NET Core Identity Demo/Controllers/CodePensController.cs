using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Identity_Demo.Controllers
{
    public class CodePensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PointerLock()
        {
            return View();
        }
    }
}
