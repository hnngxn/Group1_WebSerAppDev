using Microsoft.AspNetCore.Mvc;

namespace Group1_WebSerAppDev.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
