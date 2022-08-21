using FluentBlog.Main;
using FluentBlog.Service.Category;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Fast.Components.FluentUI;
using Fluxor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddFluxor(options => options.ScanAssemblies(typeof(FluentBlog.Store.Locator).Assembly));
builder.Services.AddScoped<IconService>();
builder.Services.AddScoped<CategoryHelper>();

await builder.Build().RunAsync();
