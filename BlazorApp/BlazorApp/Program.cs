using BlazorApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.SessionStorage;
using Microsoft.Extensions.Configuration;
using MyComponentsLibrary;
using MyComponentsLibrary.Services;
using ServicesLibrary;
using ServicesLibrary.Services;
using SqliteWasmHelper;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Data;

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
builder.Services.AddBlazoredSessionStorageAsSingleton();
builder.Services.AddSqliteWasmDbContextFactory<BrandContext>(options =>
{
    options.UseSqlite("Data source=brands.sqlite3");
});
builder.Services.AddOidcAuthentication(options =>
{
    builder.Configuration.Bind("Authentication", options.ProviderOptions);
});

await builder.Build().RunAsync();
