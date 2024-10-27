using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class DeParaInsumoSKURepositorio : RepositorioBase<DeParaInsumoSKU>, IDeParaInsumoSKURepositorio
  {
    public DeParaInsumoSKURepositorio(Contexto context) : base(context)
    {
    }
  }
}
