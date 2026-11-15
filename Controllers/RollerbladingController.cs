using Group1_WebSerAppDev.Data;
using Microsoft.AspNetCore.Mvc;

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
            var activities = _context.CardioActivities
                .OrderByDescending(a => a.Met)
                .ThenBy(a => a.Name)
                .ToList();
            return View(activities); // database table page
        }
    }
}
