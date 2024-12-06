namespace Rezervation.FlightAPI.ViewModels
{
    public class FlightVM
    {
        public string FlightNo { get; set; }
        public string Airline { get; set; }
        public decimal Price { get; set; }
        public string PassengerNameSurname { get; set; }
        public DateTime RezervationDate { get; set; }
    }
}
