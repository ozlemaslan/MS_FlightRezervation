using Rezervation.Shared.BaseEntity;

namespace Rezervation.FlightAPI.Entities
{
    public class Flight : BaseEntity
    {
        public string FlightNo { get; set; } 
        public string Airline { get; set; }
        public decimal Price { get; set; } 
    }
}
