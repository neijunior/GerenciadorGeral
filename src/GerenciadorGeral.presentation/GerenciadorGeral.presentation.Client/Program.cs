using GerenciadorGeral.application.Servicos;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.Register()

var host = builder.Build();



await builder.Build().RunAsync();
