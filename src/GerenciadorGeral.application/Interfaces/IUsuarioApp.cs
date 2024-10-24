using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface IUsuarioApp : IAppBase<Usuario, UsuarioDTO>
  { 
    Task<ICollection<UsuarioDTO>> Listar();
  }
}
