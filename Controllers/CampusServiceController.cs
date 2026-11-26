using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCampusPortal.Data;
using SmartCampusPortal.Models;

namespace SmartCampusPortal.Controllers
{
    public class CampusServiceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CampusServiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var services = await _context.CampusServices.ToListAsync();

            return View(services);
        }
        // Display Create Form
        public IActionResult Create()
        {
            return View();
        }

        // Save Campus Service
        [HttpPost]
        public async Task<IActionResult> Create(CampusService service)
        {
            _context.CampusServices.Add(service);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public IActionResult ApiServices()
        {
            return View();
        }
    }

}