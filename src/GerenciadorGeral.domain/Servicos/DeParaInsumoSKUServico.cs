using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class DeParaInsumoSKUServico : ServicoBase<DeParaInsumoSKU>, IDeParaInsumoSKUServico
  {
    protected IDeParaInsumoSKURepositorio _repositorio;  
    
    public DeParaInsumoSKUServico(IDeParaInsumoSKURepositorio repositorio) : base(repositorio)
    {
      this._repositorio = repositorio;
    }

    //public async Task<DeParaInsumoSKU> Consultar(Guid Id)
    //{
    //  var compra = await _repositorio.Consultar<Compra>(w => w.Id == Id);
    //  var itens = await _repositorio.Listar<CompraItem>(w => w.IdCompra == Id, i => i.SKU);

    //  compra.ListaItens = itens;

    //  return compra;
    //}
  }
}
