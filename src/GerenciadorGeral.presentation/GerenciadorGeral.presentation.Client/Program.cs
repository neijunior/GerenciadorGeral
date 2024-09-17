using GerenciadorGeral.application.Servicos;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GerenciadorGeral.infra.IoC;
using GerenciadorGeral.application;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAutoMapper(typeof(MappingEntidade).Assembly);
builder.Services.RegisterAplicacao(); 

var host = builder.Build();



await builder.Build().RunAsync();
