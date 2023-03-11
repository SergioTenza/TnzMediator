
using Microsoft.Extensions.DependencyInjection;
using TnzMediator.DependencyInjection;
using TnzMediatorConsole.Requests;
using TnzMediatorCore;

//Service provider
var serviceProvider = new ServiceCollection()
    .AddMediator(ServiceLifetime.Scoped, typeof(Program))
    .BuildServiceProvider();

//request
var request = new PrintToConsoleRequest { Text = "Hello from Mediator TNZ" };

//mediator
var mediator = serviceProvider.GetRequiredService<IMediator>();
await mediator.SendAsync(request);