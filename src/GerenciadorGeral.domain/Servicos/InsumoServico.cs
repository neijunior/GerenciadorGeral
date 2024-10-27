using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class InsumoServico : ServicoBase<Insumo>, IInsumoServico
  {
    protected IInsumoRepositorio _repositorio;  
    
    public InsumoServico(IInsumoRepositorio repositorio) : base(repositorio)
    {
      this._repositorio = repositorio;
    }

    //public async Task<Insumo> Consultar(Guid Id)
    //{
    //  var compra = await _repositorio.Consultar<Compra>(w => w.Id == Id);
    //  var itens = await _repositorio.Listar<CompraItem>(w => w.IdCompra == Id, i => i.SKU);

    //  compra.ListaItens = itens;

    //  return compra;
    //}
  }
}
