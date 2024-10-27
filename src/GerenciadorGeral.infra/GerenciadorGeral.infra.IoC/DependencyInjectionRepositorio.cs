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
      svcCollection.AddScoped<ICompraRepositorio, CompraRepositorio>();
      svcCollection.AddScoped<ICompraItemRepositorio, CompraItemRepositorio>();
      svcCollection.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();
      svcCollection.AddScoped<IMenuRepositorio, MenuRepositorio>();
      svcCollection.AddScoped<ISKURepositorio, SKURepositorio>();
      svcCollection.AddScoped<IUnidadeMedidaRepositorio, UnidadeMedidaRepositorio>();
      svcCollection.AddScoped<IMarcaRepositorio, MarcaRepositorio>();
      svcCollection.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
      svcCollection.AddScoped<ICustoProducaoRepositorio, CustoProducaoRepositorio>();
      svcCollection.AddScoped<ICustoProducaoDetalheRepositorio, CustoProducaoDetalheRepositorio>();
      svcCollection.AddScoped<IInsumoRepositorio, InsumoRepositorio>();
      svcCollection.AddScoped<IDeParaInsumoSKURepositorio, DeParaInsumoSKURepositorio>();
    }

  }
}
