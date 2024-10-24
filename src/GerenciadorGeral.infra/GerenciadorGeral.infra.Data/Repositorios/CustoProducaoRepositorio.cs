using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class CustoProducaoRepositorio : RepositorioBase<CustoProducao>, ICustoProducaoRepositorio
  {
    public CustoProducaoRepositorio(Contexto context) : base(context)
    {
    }

  }
}
