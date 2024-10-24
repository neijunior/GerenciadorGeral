using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class CustoProducaoApp : AppBase<CustoProducao, CustoProducaoDTO>, ICustoProducaoApp
  {
    protected readonly ICustoProducaoServico _servicoCustoProducao;
    protected readonly ICompraItemServico _servicoCompraItem;
    protected readonly IMapper _iMapper;
    public CustoProducaoApp(IMapper iMapper, ICustoProducaoServico servicoCustoProducao, ICompraItemServico servicoCompraItem) : base(iMapper, servicoCustoProducao)
    {
      this._iMapper = iMapper;
      this._servicoCustoProducao = servicoCustoProducao;
      this._servicoCompraItem = servicoCompraItem;
    }

    public async Task<ICollection<CustoProducaoDetalheDTO>> ConsultaCustoPadrao(ICollection<CustoProducaoDetalheDTO> listaItens)
    {

      ICollection<CustoProducaoDetalheDTO> lista = new HashSet<CustoProducaoDetalheDTO>();

      foreach (var item in listaItens)
      {
        var ultimaCompra = await _servicoCompraItem.ConsultarUltimaCompra(item.IdSKU);
        lista.Add(new CustoProducaoDetalheDTO() {
          Id = Guid.NewGuid(),
          IdSKU = item.IdSKU,
          qtdUtilizada = item.qtdUtilizada, 
          CustoAquisicaoItem = item.CustoAquisicaoItem
        });
      }

      foreach (var item in lista)
      {
        item.ValorCustoProducao = ((item.CustoAquisicaoItem * item.qtdUtilizada) / item.SKU.Quantidade);
      }

      return lista;
    }

    public async Task<CustoProducaoDTO> Consultar(Guid Id)
    {
      var item = await this._servicoCustoProducao.Consultar(Id);

      return this._iMapper.Map<CustoProducaoDTO>(item);

    }

    public async Task<ICollection<CustoProducaoDTO>> Listar()
    {

      return null;

    }

    private async Task<ICollection<CustoProducaoDTO>> TratarCusto(ICollection<CustoProducaoDTO> listaCusto)
    {
    //  ICollection<CustoProducaoDTO> listaTratada = new HashSet<CustoProducaoDTO>();
    //  foreach (var item in listaCusto)
    //  {
    //    item.valorCustoProducao = ((item.valorCompra * item.qtd) / item.skuDTO.Quantidade);
    //    listaTratada.Add(item);
    //  }

      return null;
    }
  }
}
