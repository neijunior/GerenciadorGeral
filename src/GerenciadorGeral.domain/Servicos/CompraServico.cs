using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class CompraServico : ServicoBase<Compra>, ICompraServico
  {
    public CompraServico(ICompraRepositorio repositorio) : base(repositorio)
    {
    }
  }
}
