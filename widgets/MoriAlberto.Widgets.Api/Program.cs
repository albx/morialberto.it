using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoriAlberto.Widgets.Api.Services;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices((ctx, services) =>
    {
        services.AddScoped<RateService>();
    })
    .Build();

host.Run();
