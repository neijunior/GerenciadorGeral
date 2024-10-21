using GerenciadorGeral.application.DTO;

namespace GerenciadorGeral.application.Interfaces
{
  public interface ICustoProducaoApp
  {
    Task<ICollection<CustoProducaoDTO>> ConsultaCustoPadrao();
    Task<ICollection<CustoProducaoDTO>> Listar();
  }
}
