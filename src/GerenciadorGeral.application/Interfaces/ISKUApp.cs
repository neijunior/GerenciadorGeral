using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface ISKUApp : IAppBase<SKU, SKUDTO>
  {
    Task<ICollection<SKUDTO>> ListarProdutoInterno();
  }
}
