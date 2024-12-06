using MassTransit;

namespace Rezervation.Shared.Events.HostelEvents
{
    public class HostelNotRezervated : CorrelatedBy<Guid>
    {
        public HostelNotRezervated(Guid correlationId)
        {
            CorrelationId = correlationId;
        }
        public Guid CorrelationId { get; set; }
        public int RezervationId { get; set; }
        public string Message { get; set; } //neden rezerve edilemedi sebebi?
    }
}
