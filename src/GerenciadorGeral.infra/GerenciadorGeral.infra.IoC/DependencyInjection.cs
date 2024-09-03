using GerenciadorGeral.application;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.application.Servicos;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;
using GerenciadorGeral.domain.Servicos;
using GerenciadorGeral.infra.Data.Contextos;
using GerenciadorGeral.infra.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorGeral.infra.IoC
{
  public static class DependencyInjection
  {
    public static void Register(this IServiceCollection svcCollection, IConfiguration configuration)
    {
      svcCollection.AddAutoMapper(typeof(MappingEntidade).Assembly);

      //Aplicação
      svcCollection.RegisterAplicacao();
      //Domínio
      svcCollection.RegisterDominio();
      //Repositorio
      svcCollection.RegisterRepositorio();


      svcCollection.AddSqlConfiguration(configuration);
    }

    private static void AddSqlConfiguration(this IServiceCollection svcCollection, IConfiguration configuration)
    {
      svcCollection.AddDbContext<Contexto>(opt => opt.UseSqlServer(configuration.GetConnectionString("ConnAtivo"), b =>
      {
        b.MigrationsAssembly("GerenciadorGeral.infra.Data");
        opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
      }));
    }
  }
}
