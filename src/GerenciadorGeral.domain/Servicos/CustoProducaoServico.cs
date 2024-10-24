using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class CustoProducaoServico : ServicoBase<CustoProducao>, ICustoProducaoServico
  {
    protected ICustoProducaoRepositorio _repositorio;  
    
    public CustoProducaoServico(ICustoProducaoRepositorio repositorio) : base(repositorio)
    {
      this._repositorio = repositorio;
    }

    public async Task<CustoProducao> Consultar(Guid Id)
    {
      var custo = await _repositorio.Consultar<CustoProducao>(w => w.Id == Id);
      var itens = await _repositorio.Listar<CustoProducaoDetalhe>(w => w.IdCustoProducao== Id, i => i.SKU);

      custo.ListaProducaoDetalhe = itens;

      return custo;
    }
  }
}
