using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Repositorios
{
  public interface IUnidadeMedidaRepositorio
  {
    Task<ICollection<UnidadeMedida>> SelectAll();
  }
}
