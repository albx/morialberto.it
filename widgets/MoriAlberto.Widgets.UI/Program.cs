using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MoriAlberto.Widgets.UI;
using MoriAlberto.Widgets.UI.Components;
using MoriAlberto.Widgets.UI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

if (builder.HostEnvironment.IsDevelopment())
{
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");
}

builder.RootComponents.RegisterCustomElement<Rating>("post-rating");

builder.Services.AddHttpClient<IRatingService, RatingService>(
    client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

await builder.Build().RunAsync();
