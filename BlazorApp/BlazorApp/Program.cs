using BlazorApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using MyComponentsLibrary;
using MyComponentsLibrary.Services;
using ServicesLibrary;
using ServicesLibrary.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.Configuration["ApiUrl"]

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["ApiUrl"]) });
//builder.Services.AddScoped<BrandsService>();
//builder.Services.AddScoped<CarsService>();
builder.Services.AddApiServices();
//builder.Services.AddScoped<ToastService>();//TODO
builder.Services.AddToastServices();

await builder.Build().RunAsync();
