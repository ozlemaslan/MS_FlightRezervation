using Microsoft.EntityFrameworkCore;

namespace Rezervation.HostelAPI.Entities.Context
{
    public class HostelDbContext : DbContext
    {
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<HostelRezervation> HostelRezervations { get; set; }
        public HostelDbContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
