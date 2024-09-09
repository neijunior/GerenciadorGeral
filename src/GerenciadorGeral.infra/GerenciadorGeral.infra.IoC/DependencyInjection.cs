using GerenciadorGeral.application;
using GerenciadorGeral.infra.Data.Contextos;
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
