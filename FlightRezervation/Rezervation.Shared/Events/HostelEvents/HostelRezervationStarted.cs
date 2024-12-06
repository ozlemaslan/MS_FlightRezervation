using MassTransit;

namespace Rezervation.Shared.Events.HostelEvents
{
    public class HostelRezervationStarted : CorrelatedBy<Guid>
    {
        public HostelRezervationStarted(Guid correlationId)
        {
            CorrelationId = correlationId;
        }
        public Guid CorrelationId { get; }
        public int RezervationId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
