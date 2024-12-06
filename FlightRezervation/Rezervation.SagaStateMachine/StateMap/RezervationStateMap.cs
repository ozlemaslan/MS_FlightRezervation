using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rezervation.SagaStateMachine.StateMachineInstance;

namespace Rezervation.SagaStateMachine.StateMap
{
    public class RezervationStateMap : SagaClassMap<RezervationState>
    {
        protected override void Configure(EntityTypeBuilder<RezervationState> entity, ModelBuilder model)
        {
            entity.Property(x => x.RezervationId).IsRequired();

            base.Configure(entity, model);
        }
    }
}
