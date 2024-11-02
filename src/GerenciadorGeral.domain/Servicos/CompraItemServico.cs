using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;
using Formatacao;

namespace GerenciadorGeral.domain.Servicos
{
  public class CompraItemServico : ServicoBase<CompraItem>, ICompraItemServico
  {
    protected ICompraItemRepositorio _repositorio;


    public CompraItemServico(ICompraItemRepositorio repositorio) : base(repositorio)
    {
      this._repositorio = repositorio;
    }

    public async Task<CompraItem> ConsultarUltimaCompra(Guid idSku)
    {
      var item = await _repositorio.Listar<CompraItem>(w => w.IdSku == idSku, i => i.SKU, i => i.Compra);

      return item.OrderByDescending(o => o.Compra.Data).LastOrDefault();
    }

    public async Task<decimal> ConsultarCustoMedioCompraInsumo(Guid IdInsumo)
    {
      var listaSkusInsumo = _repositorio.Listar<CompraItem>(w => w.SKU.IdInsumo == IdInsumo, i => i.SKU).Result
                            .Select(s => new
                            {
                              QtdComprada = TratarQtd(s.SKU) * s.Quantidade,
                              ValorTotal = s.ValorTotal
                            }).ToList();

      return (listaSkusInsumo.Sum(su => su.ValorTotal) / listaSkusInsumo.Sum(su => su.QtdComprada)).Truncar(2);
    }


    private decimal TratarQtd(SKU sku)
    {
      switch (sku.CodigoUnidadeMedida)
      {
        case "G":
          sku.Quantidade = (sku.Quantidade / 1000);
          break;
        default:
          break;
      }

      return sku.Quantidade;
    }
  }
}
