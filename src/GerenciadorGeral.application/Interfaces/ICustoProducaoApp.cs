using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface ICustoProducaoApp : IAppBase<CustoProducao, CustoProducaoDTO>
  {
    Task<CustoProducaoDTO> Consultar(Guid Id);
    Task<ICollection<CustoProducaoDetalheDTO>> ConsultaCustoPadrao(ICollection<CustoProducaoDetalheDTO> listaItens);
    Task<ICollection<CustoProducaoDTO>> Listar();
  }
}
