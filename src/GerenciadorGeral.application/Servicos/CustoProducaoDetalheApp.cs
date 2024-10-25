using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class CustoProducaoDetalheApp : AppBase<CustoProducaoDetalhe, CustoProducaoDetalheDTO>, ICustoProducaoDetalheApp
  {
    protected readonly ICustoProducaoDetalheServico _servicoCustoProducaoDetalhe;
    protected readonly ICompraItemServico _servicoCompraItem;
    protected readonly ISKUServico _servicoSKU;
    protected readonly IMapper _iMapper;
    public CustoProducaoDetalheApp(IMapper iMapper, ICustoProducaoDetalheServico servicoCustoProducaoDetalhe, ICompraItemServico servicoCompraItem, ISKUServico servicoSKU) : base(iMapper, servicoCustoProducaoDetalhe)
    {
      this._iMapper = iMapper;
      this._servicoCustoProducaoDetalhe = servicoCustoProducaoDetalhe;
      this._servicoCompraItem = servicoCompraItem;
      this._servicoSKU = servicoSKU;
    }

    public async Task<RetornoDTO> Salvar(CustoProducaoDetalheDTO detalhe)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Atualizado com sucesso",
        Sucesso = true
      };

      try
      {
        var sku = _iMapper.Map<SKUDTO>(await _servicoSKU.SelectById(detalhe.IdSKU));
        if (sku != null && sku.Interno)
        {
          var custoProducao = await _servicoBase.Listar<CustoProducao>(w => w.ListaProducaoDetalhe.Any(a => a.IdSKU == sku.Id), i => i.ListaProducaoDetalhe);
          var item = custoProducao.OrderByDescending(o => o.DataCalculo).FirstOrDefault();
          detalhe.CustoAquisicaoItem = item.ListaProducaoDetalhe.FirstOrDefault(w => w.IdSKU == detalhe.IdSKU).ValorCustoProducao;
        }
        else
        {
          if (detalhe.CustoAquisicaoItem == 0)
          {
            var compra = await _servicoCompraItem.ConsultarUltimaCompra(detalhe.IdSKU);
            detalhe.CustoAquisicaoItem = compra.ValorUnitario;
          }
        }

        detalhe.SKU = sku;

        TratarCusto(ref detalhe);

        detalhe.SKU = null;
        detalhe.CustoProducao = null;

        CustoProducaoDetalhe compraItemBD = await _servicoBase.Consultar<CustoProducaoDetalhe>(w => w.Id == detalhe.Id);
        bool novo = compraItemBD == null;
        compraItemBD = _iMapper.Map<CustoProducaoDetalhe>(detalhe);

        if (novo)
          await _servicoBase.Insert(compraItemBD);
        else
          await _servicoBase.Update(compraItemBD);

        //await AtualizarDadosCompra(compraItem);

      }
      catch (Exception ex)
      {
        retorno.Mensagem = ex.Message;
        retorno.Sucesso = false;
      }

      return retorno;

    }

    private decimal TratarQtdUnidadeMedida(SKUDTO sku)
    {
      switch (sku.CodigoUnidadeMedida)
      {
        case "G":
          sku.Quantidade = sku.Quantidade / 1000;
          break;
        default:
          break;
      }

      return sku.Quantidade;
    }

    private void TratarCusto(ref CustoProducaoDetalheDTO detalhe)
    {
      detalhe.ValorCustoProducao = ((detalhe.CustoAquisicaoItem * detalhe.qtdUtilizada) / TratarQtdUnidadeMedida(detalhe.SKU));

    }

  }
}
