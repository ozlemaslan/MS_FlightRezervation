namespace Rezervation.FlightAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Rezervation.FlightAPI.Entities;
    using Rezervation.FlightAPI.Entities.Context;
    using Rezervation.FlightAPI.ViewModels;
    using Rezervation.Shared.Events.FlightEvents;

    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly FlightDbContext _context;
        public FlightController(FlightDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> CreateFlightRezervation(FlightVM flightVM)
        {
            Flight flight = new()
            {
                Airline = flightVM.Airline,
                FlightNo = flightVM.FlightNo,
                Price = flightVM.Price,
            };

            await _context.Flights.AddAsync(flight);
            await _context.SaveChangesAsync();

            FlightRezervation flightRezervation = new()
            {
                FlightId = flight != null ? flight.Id : 0,
                PassengerNameSurname = flightVM.PassengerNameSurname,
                RezervationDate = flightVM.RezervationDate,
                Status = Shared.Enums.RezervationStatus.Pending,
            };

            await _context.FlightRezervations.AddAsync(flightRezervation);
            await _context.SaveChangesAsync();

            HostelRezervationstarted flightRezervationStarted = new()
            {
                FlightId = flight.Id,
                FlightNo = flightVM.FlightNo,
                Price = flightVM.Price,
                PassengerNameSurname = flightVM.PassengerNameSurname,
            };

            // saga stateine gönderilecek olan event

            return Ok();
        }
    }
}
