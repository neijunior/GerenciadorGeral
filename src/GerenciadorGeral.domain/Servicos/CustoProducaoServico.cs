using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System.Xml.Serialization;

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
      var itens = await _repositorio.Listar<CustoProducaoDetalhe>(w => w.IdCustoProducao == Id, i => i.Insumo);

      custo.ListaProducaoDetalhe = itens;

      return custo;

    }

    public async Task<ICollection<CustoProducao>> Listar()
    {
      var itens = await _repositorio.Listar<CustoProducao>(null,
                                                           i => i.SKU,
                                                           i => i.ListaProducaoDetalhe);

      var idsInsumos = itens.SelectMany(sm => sm.ListaProducaoDetalhe.Select(s => s.IdInsumo)).ToList();
      if (idsInsumos != null && idsInsumos.Count() > 0)
      {
        var skus = await _repositorio.Listar<Insumo>(w => idsInsumos.Contains(w.Id));
        foreach (var cp in itens)
        {
          foreach (var det in cp.ListaProducaoDetalhe)
          {
            det.Insumo = skus.FirstOrDefault(w => w.Id == det.IdInsumo);
          }
        }
      }
      return itens;

    }
  }
}
