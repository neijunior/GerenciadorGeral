using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class UnidadeMedidaRepositorio : IUnidadeMedidaRepositorio
  {
    protected readonly Contexto _contexto;
    public UnidadeMedidaRepositorio(Contexto context) 
    {
      this._contexto = context;
    }

    public async Task<ICollection<UnidadeMedida>> SelectAll()
    {
      return _contexto.Set<UnidadeMedida>().ToList();
    }
  }
}
