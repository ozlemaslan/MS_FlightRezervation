using MassTransit;

namespace Rezervation.Shared.Events.FlightEvents
{
    public class HostelRezervationstarted 
    {
       public int FlightId { get; set; }
        public string FlightNo { get; set; }
        public string PassengerNameSurname { get; set; }
        public decimal Price { get; set; }
    }
}
