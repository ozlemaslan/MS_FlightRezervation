using MassTransit;

namespace Rezervation.Shared.Events.FlightEvents
{
    // CorrelationId değer uçak başarılı bir şekilde rezerve edildi ise hostel bakmaya git. Uçak rezerve CorrelationId değeri örn:123 diyelim. Sonra bu değer ile hostel bakmaya gidecek.Böylelikle akış sağlanmış olacak yani db de corelationıd değeri 123 olanların durumu ne halde onu kontrol etmek için correliationId eklendi.
    public class FlightRezervated : CorrelatedBy<Guid>
    {
        public FlightRezervated(Guid correlationId)
        {
            CorrelationId = correlationId;
        }
        public Guid CorrelationId { get; } //bu saga da akışı uniqe bir şekilde yönetmek için yapılmış guid değer

        public int RezervationId { get; set; }
        public int FlightId { get; set; }
        public string FlightNo { get; set; }
    }
}
