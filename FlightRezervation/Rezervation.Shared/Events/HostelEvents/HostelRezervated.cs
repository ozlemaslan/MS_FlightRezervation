using MassTransit;

namespace Rezervation.Shared.Events.HostelEvents
{
    public class HostelRezervated : CorrelatedBy<Guid>
    {
        public HostelRezervated(Guid correlationId)
        {
            CorrelationId = correlationId;
        }
        public Guid CorrelationId { get; set; }
        public int RezervationId { get; set; }
        public int HostelId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
