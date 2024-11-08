using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class CustoProducaoDetalheServico : ServicoBase<CustoProducaoDetalhe>, ICustoProducaoDetalheServico
  {
    protected ICustoProducaoDetalheRepositorio _repositorio;
    public CustoProducaoDetalheServico(ICustoProducaoDetalheRepositorio repositorio) : base(repositorio)
    {
      this._repositorio = repositorio;
    }

    public async Task<CustoProducaoDetalhe> ConsultarUltimaCompra(string codigoSKU)
    {
      //var item = await _repositorio.ConsultarUltimo<CustoProducaoDetalhe>(w => w.SKU.Codigo == codigoSKU, i => i.SKU);
      //return item;
      return null;
    }

    public async Task SalvarLista(ICollection<CustoProducaoDetalhe> lista)
    {
      try
      {
        foreach (var item in lista)
        {
          CustoProducaoDetalhe det = Consultar<CustoProducaoDetalhe>(w => w.Id == item.Id, i => i.Insumo).Result;
          bool novo = (det == null);


          if (novo)
          {
            det.Id = Guid.NewGuid();
            Insert(det);
          }
          else
          {
            det = item;
            det.Insumo = null;
            det.CustoProducao = null;
            Update(det);
          }
        }
        
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
