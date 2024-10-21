using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Servicos
{
  public interface ICompraItemServico : IServicoBase<CompraItem>
  {
    Task<CompraItem> ConsultarUltimaCompra(string codigoSKU);
  }
}
