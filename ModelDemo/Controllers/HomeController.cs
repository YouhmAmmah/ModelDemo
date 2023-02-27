using Microsoft.AspNetCore.Mvc;

namespace ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
