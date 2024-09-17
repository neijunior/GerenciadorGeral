using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface ICompraApp : IAppBase<Compra, CompraDTO>
  {
    Task<CompraDTO> Consultar (Guid Id);
    Task<ICollection<CompraDTO>> Listar();
  }
}
