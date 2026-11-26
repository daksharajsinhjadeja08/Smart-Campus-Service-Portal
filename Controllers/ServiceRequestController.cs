
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCampusPortal.Data;
using SmartCampusPortal.Models;

namespace SmartCampusPortal.Controllers
{
    public class ServiceRequestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceRequestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var requests = await _context.ServiceRequests
                .ToListAsync();

            return View(requests);
        }
        // Display Request Form
        public IActionResult Create()
        {
            return View();
        }

        // Update Request Status
        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            var request = await _context.ServiceRequests.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            request.Status = status;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Save Service Request
        [HttpPost]
        public async Task<IActionResult> Create(ServiceRequest request)
        {
            request.Status = "Pending";

            _context.ServiceRequests.Add(request);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
