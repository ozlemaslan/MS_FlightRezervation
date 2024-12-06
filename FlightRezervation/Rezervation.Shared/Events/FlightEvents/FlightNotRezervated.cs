using MassTransit;

namespace Rezervation.Shared.Events.FlightEvents
{
    public class FlightNotRezervated 
    { 
        public int RezervationId { get; set; }
        public string Message { get; set; } //neden rezerve edilemedi sebebi?
    }
}
