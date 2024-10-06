using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class CompraServico : ServicoBase<Compra>, ICompraServico
  {
    protected ICompraRepositorio _repositorio;  
    
    public CompraServico(ICompraRepositorio repositorio) : base(repositorio)
    {
      this._repositorio = repositorio;
    }

    public async Task<Compra> Consultar(Guid Id)
    {
      var compra = await _repositorio.Consultar<Compra>(w => w.Id == Id);
      var itens = await _repositorio.Listar<CompraItem>(w => w.IdCompra == Id, i => i.SKU);

      compra.ListaItens = itens;

      return compra;
    }
  }
}
