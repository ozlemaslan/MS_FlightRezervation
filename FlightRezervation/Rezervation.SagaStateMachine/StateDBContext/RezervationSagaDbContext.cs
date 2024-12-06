using MassTransit.EntityFrameworkCoreIntegration;
using Microsoft.EntityFrameworkCore;
using Rezervation.SagaStateMachine.StateMap;

namespace Rezervation.SagaStateMachine.StateDBContext
{
    public class RezervationSagaDbContext : SagaDbContext
    {
        public RezervationSagaDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
            
        }
        protected override IEnumerable<ISagaClassMap> Configurations
        {
            get
            {
                yield return new RezervationStateMap();
            }
        }
    }
}
