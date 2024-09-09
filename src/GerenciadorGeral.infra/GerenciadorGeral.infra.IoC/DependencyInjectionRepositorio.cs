using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorGeral.infra.IoC
{
  public static class DependencyInjectionRepositorio
  {
    public static void RegisterRepositorio(this IServiceCollection svcCollection)
    {
      svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
      svcCollection.AddScoped<ISKURepositorio, SKURepositorio>();
      svcCollection.AddScoped<IUnidadeMedidaRepositorio, UnidadeMedidaRepositorio>();
      svcCollection.AddScoped<ICompraRepositorio, CompraRepositorio>();
      svcCollection.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();
      svcCollection.AddScoped<IMenuRepositorio, MenuRepositorio>();
    }

  }
}
