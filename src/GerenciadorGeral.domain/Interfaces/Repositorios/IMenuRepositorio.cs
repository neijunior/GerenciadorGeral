using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Repositorios
{
  public interface IMenuRepositorio : IRepositorioBase<Menu>
  {
    Task<ICollection<Menu>> ListarFilhos(Guid Id);
    Task<ICollection<Menu>> ListarNivelZero();
  }
}
