using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class UnidadeMedidaServico: IUnidadeMedidaServico
  {   

    protected readonly IUnidadeMedidaRepositorio _repositorio;
    public UnidadeMedidaServico(IUnidadeMedidaRepositorio repositorio)
    {
      this._repositorio = repositorio;
    }

    public async Task<ICollection<UnidadeMedida>> SelectAll()
    {
      return await _repositorio.SelectAll();
    }
  }
}
