using GerenciadorGeral.domain.Interfaces.Servicos;
using GerenciadorGeral.domain.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorGeral.infra.IoC
{
  public static class DependencyInjectionDominio
  {
    public static void RegisterDominio(this IServiceCollection svcCollection)
    {
      svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
      svcCollection.AddScoped<ICompraServico, CompraServico>();
      svcCollection.AddScoped<ICompraItemServico, CompraItemServico>();
      svcCollection.AddScoped<IFornecedorServico, FornecedorServico>();
      svcCollection.AddScoped<IMenuServico, MenuServico>();
      svcCollection.AddScoped<ISKUServico, SKUServico>();
      svcCollection.AddScoped<IUnidadeMedidaServico, UnidadeMedidaServico>();
      svcCollection.AddScoped<IMarcaServico, MarcaServico>();
    }
  }
}
