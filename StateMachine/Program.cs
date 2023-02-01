using StateMachine;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddTransient<StateFactory>();
    })
    .Build();

await host.RunAsync();
