using System;
using System.Net.Http;
using CA3;
using CA3.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Default HttpClient used for external APIs
builder.Services.AddScoped(sp => new HttpClient());

// Register OpenLiga API service
builder.Services.AddScoped<OpenLigaService>();

await builder.Build().RunAsync();
