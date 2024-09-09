using GerenciadorGeral.application.Servicos;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Reflection.Emit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var host = builder.Build();
host.Services.GetRequiredService<CompraApp>();


await builder.Build().RunAsync();
