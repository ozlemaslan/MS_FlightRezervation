using Rezervation.Shared.BaseEntity;

namespace Rezervation.HostelAPI.Entities
{
    public class Hostel : BaseEntity
    {
        public string HostelName { get; set; } 
        public int TotalRooms { get; set; } 
        public decimal PriceNight { get; set; } 
    }
}
