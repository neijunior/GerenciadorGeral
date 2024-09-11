using GerenciadorGeral.application.Servicos;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GerenciadorGeral.infra.IoC;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.RegisterAplicacao(); 

var host = builder.Build();



await builder.Build().RunAsync();
