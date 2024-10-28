using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface IDeParaInsumoSKUApp : IAppBase<DeParaInsumoSKU, DeParaInsumoSKUDTO>
  {
    Task<ICollection<DeParaInsumoSKUDTO>> Listar();
    Task<DeParaInsumoSKUDTO> Consultar(Guid Id);
    Task<RetornoDTO> Excluir(Guid Id);
    Task<RetornoDTO> Salvar(DeParaInsumoSKUDTO marca);
  }
}
