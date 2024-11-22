using Rezervation.Shared.BaseEntity;
using Rezervation.Shared.Enums;

namespace Rezervation.HostelAPI.Entities
{
    public class HostelRezervation : BaseEntity
    {
        public int HostelId { get; set; }
        public Hostel Hostel { get; set; }
        public string GuestName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public RezervationStatus Status { get; set; }
    }
}
