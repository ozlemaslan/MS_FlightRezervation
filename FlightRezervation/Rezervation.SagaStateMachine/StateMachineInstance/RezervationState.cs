using MassTransit;

namespace Rezervation.SagaStateMachine.StateMachineInstance
{
    /// <summary>
    /// Gelen herbir istek state instancedır. Haliyle bunların herbirini ayırt etmek için uniqe CorrelationId değeri tutmalıyız.
    /// </summary>
    public class RezervationState : SagaStateMachineInstance
    {
        public Guid CorrelationId { get; set; }
        public string CurrentState { get; set;}
        public int RezervationId { get; set; }
    }
}
