using Microsoft.AspNetCore.Mvc;
using Rezervation.HostelAPI.Entities;
using Rezervation.HostelAPI.Entities.Context;
using Rezervation.Shared.Events.FlightEvents;

namespace Rezervation.HostelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostelController : ControllerBase
    {
        private readonly HostelDbContext _context;
        public HostelController(HostelDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> CreateHostelRezervation()
        {
            Hostel hostel = new()
            {

            };

            await _context.Hostels.AddAsync(hostel);
            await _context.SaveChangesAsync();

            HostelRezervation hostelRezervation = new()
            {
                Status = Shared.Enums.RezervationStatus.Pending,
            };

            await _context.HostelRezervations.AddAsync(hostelRezervation);
            await _context.SaveChangesAsync();

            HostelRezervationstarted hostelRezervationStarted = new()
            {
            };

            return Ok();
        }
    }
}
