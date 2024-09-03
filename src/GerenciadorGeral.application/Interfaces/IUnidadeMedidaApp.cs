using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface IUnidadeMedidaApp
  {
    Task<ICollection<UnidadeMedidaDTO>> SelectAll();
  }
}
