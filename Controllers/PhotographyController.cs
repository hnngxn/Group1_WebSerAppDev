using Group1_WebSerAppDev.Data;
using Microsoft.AspNetCore.Mvc;

namespace Group1_WebSerAppDev.Controllers
{
    public class PhotographyController : Controller
    {
        private readonly AppDbContext _context;

        public PhotographyController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(); // info/gallery page
        }

        public IActionResult Photos()
        {
            var photos = _context.Photos.ToList();
            return View(photos); // database table page
        }
    }
}