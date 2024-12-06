using Rezervation.SagaStateMachine.StateMachine;

var builder = Host.CreateApplicationBuilder(args);
//builder.Services.AddHostedService<RezervationStateMachine>();

var host = builder.Build();
host.Run();
