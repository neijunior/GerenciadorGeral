using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

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

    //public async decimal ConsultarCustoMedioCompra(Guid IdSku)
    //{      
    //  var listaSkusInsumo = await _repositorio.Listar<SKU>(w => w.ListaDeParaInsumoSKU.Any(a => a.IdSKU == IdSku));

    //  var idsSku = listaSkusInsumo.Select(s => s.Id).ToArray();

    //  var lista = await _repositorio.Listar<CompraItem>(w => idsSku.Contains(w.IdSku));

    //  return 0.0D;
    //  //return await _repositorio.Listar<CompraItem>(w => w.IdCompra == IdCompra);
    //}

  }
}
