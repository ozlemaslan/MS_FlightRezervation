using Rezervation.Shared.BaseEntity;
using Rezervation.Shared.Enums;

namespace Rezervation.FlightAPI.Entities
{
    public class FlightRezervation : BaseEntity
    {
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public string PassengerNameSurname { get; set; }
        public DateTime RezervationDate { get; set; }
        public RezervationStatus Status { get; set; }
    }
}
