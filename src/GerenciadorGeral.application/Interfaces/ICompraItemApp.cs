using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.application.Interfaces
{
  public interface ICompraItemApp : IAppBase<CompraItem, CompraItemDTO>
  {
    Task<RetornoDTO> Salvar(CompraItem compraItem);
    Task<RetornoDTO> AtualizarDadosCompra(CompraItem compraItem);
  }
}
