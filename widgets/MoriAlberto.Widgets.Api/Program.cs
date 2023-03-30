using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoriAlberto.Widgets.Api.Configuration;
using MoriAlberto.Widgets.Api.Services;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices((ctx, services) =>
    {
        services.Configure<KittConfigurationOptions>(options =>
        {
            options.ConnectionString = ctx.Configuration["KittConnectionString"];
        });

        services.AddScoped<RateService>();
    })
    .Build();

host.Run();
