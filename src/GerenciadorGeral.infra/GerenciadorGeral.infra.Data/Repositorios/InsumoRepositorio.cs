using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class InsumoRepositorio : RepositorioBase<Insumo>, IInsumoRepositorio
  {
    public InsumoRepositorio(Contexto context) : base(context)
    {
    }
  }
}
