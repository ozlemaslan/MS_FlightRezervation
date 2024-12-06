using MassTransit;
using Rezervation.SagaStateMachine.StateMachineInstance;
using Rezervation.Shared.Events.FlightEvents;
using Rezervation.Shared.Events.HostelEvents;

namespace Rezervation.SagaStateMachine.StateMachine
{
    public class RezervationStateMachine : MassTransitStateMachine<RezervationState>
    {
        public Event<HostelRezervationstarted> FlightRezervationStarted { get; private set; }
        public Event<FlightRezervated> FlightRezervated { get; private set; }
        public Event<FlightNotRezervated> FlightNotRezervated { get; private set; }
        public Event<HostelRezervated> HostelRezervated { get; private set; }
        public Event<HostelNotRezervated> HostelNotRezervated { get; private set; }


    }
}
