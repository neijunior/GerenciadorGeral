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

    public async Task<CompraItem> ConsultarUltimaCompra(string codigoSKU)
    {      
      var item = await _repositorio.ConsultarUltimo<CompraItem>(w => w.SKU.Codigo == codigoSKU, i => i.SKU, i => i.Compra);
      return item;
    }

  }
}
