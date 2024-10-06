using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.application.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorGeral.infra.IoC
{
    public static class DependencyInjectionAplicacao
    {
        public static void RegisterAplicacao(this IServiceCollection svcCollection)
        {
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(AppBase<,>));
            svcCollection.AddScoped<ICompraApp, CompraApp>();
            svcCollection.AddScoped<ICompraItemApp, CompraItemApp>();
            svcCollection.AddScoped<IFornecedorApp, FornecedorApp>();
            svcCollection.AddScoped<IMenuApp, MenuApp>();
            svcCollection.AddScoped<ISKUApp, SKUApp>();
            svcCollection.AddScoped<IUnidadeMedidaApp, UnidadeMedidaApp>();            
        }
    }
}
