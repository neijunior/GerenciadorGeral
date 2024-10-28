using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface IInsumoApp : IAppBase<Insumo, InsumoDTO>
  {
    Task<ICollection<InsumoDTO>> Listar();
    Task<InsumoDTO> Consultar(Guid Id);
    Task<RetornoDTO> Excluir(Guid Id);
    Task<RetornoDTO> Salvar(InsumoDTO marca);
    decimal RetornaCustoMedioInsumo(Guid Id);
  }
}
