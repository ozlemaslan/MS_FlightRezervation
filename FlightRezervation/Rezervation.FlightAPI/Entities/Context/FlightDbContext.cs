using Microsoft.EntityFrameworkCore;
namespace Rezervation.FlightAPI.Entities.Context
{
    public class FlightDbContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightRezervation> FlightRezervations { get; set; }

        public FlightDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
