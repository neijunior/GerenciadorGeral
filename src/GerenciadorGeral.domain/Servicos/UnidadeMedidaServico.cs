using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class UnidadeMedidaServico : ServicoBase<UnidadeMedida>, IUnidadeMedidaServico
  {
    public UnidadeMedidaServico(IUnidadeMedidaRepositorio repositorio) : base(repositorio)
    {

    }
  }
}
