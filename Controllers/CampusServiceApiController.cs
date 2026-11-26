
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCampusPortal.Data;
using SmartCampusPortal.Models;

namespace SmartCampusPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusServiceApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CampusServiceApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CampusServiceApi
        [HttpGet]
        public async Task<IActionResult> GetServices()
        {
            var services = await _context.CampusServices.ToListAsync();

            return Ok(services);
        }
        // GET: api/CampusServiceApi/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var service = await _context.CampusServices
                .FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            return Ok(service);
        }
        // POST: api/CampusServiceApi
        [HttpPost]
        public async Task<IActionResult> CreateService(CampusService service)
        {
            _context.CampusServices.Add(service);

            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetService),
                new { id = service.ServiceId },
                service);
        }
        // PUT: api/CampusServiceApi/1
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateService(int id, CampusService service)
        {
            if (id != service.ServiceId)
            {
                return BadRequest();
            }

            _context.Entry(service).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE: api/CampusServiceApi/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            var service = await _context.CampusServices.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            _context.CampusServices.Remove(service);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
