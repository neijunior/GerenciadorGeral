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
      var item = await _repositorio.ConsultarUltimo<CustoProducaoDetalhe>(w => w.SKU.Codigo == codigoSKU, i => i.SKU);
      return item;
    }
  }
}
