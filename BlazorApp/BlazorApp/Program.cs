using BlazorApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using MyComponentsLibrary.Services;
using ServicesLibrary.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.Configuration["ApiUrl"]

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["ApiUrl"]) });
builder.Services.AddScoped<BrandsService>();
builder.Services.AddScoped<CarsService>();
builder.Services.AddScoped<ToastService>();//TODO

await builder.Build().RunAsync();
