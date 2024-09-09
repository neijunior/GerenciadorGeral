using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface IMenuApp : IAppBase<Menu, MenuDTO>
  {
    Task<ICollection<MenuDTO>> MontarMenu();
    Task<ICollection<MenuDTO>> ListarFilhos(Guid IdPai);
  }
}
