using Group1_WebSerAppDev.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Group1_WebSerAppDev.Controllers
{
    public class RollerbladingController : Controller
    {
        private readonly AppDbContext _context;

        public RollerbladingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Compare()
        {
            var paces = _context.ActivityPaces
                .Include(p => p.CardioActivity)
                .OrderByDescending(p => p.Met)
                .ThenBy(p => p.CardioActivity.Name)
                .ToList();
            return View(paces); // database table page
        }
    }
}
