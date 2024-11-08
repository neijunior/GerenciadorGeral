using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System.Collections.Generic;
using Formatacao;

namespace GerenciadorGeral.application.Servicos
{
  public class CustoProducaoDetalheApp : AppBase<CustoProducaoDetalhe, CustoProducaoDetalheDTO>, ICustoProducaoDetalheApp
  {
    protected readonly ICustoProducaoDetalheServico _servicoCustoProducaoDetalhe;
    protected readonly ICompraItemServico _servicoCompraItem;
    protected readonly ISKUServico _servicoSKU;
    protected readonly IInsumoServico _servicoInsumo;
    protected readonly IMapper _iMapper;
    public CustoProducaoDetalheApp(IMapper iMapper, ICustoProducaoDetalheServico servicoCustoProducaoDetalhe, ICompraItemServico servicoCompraItem, 
                                   ISKUServico servicoSKU, IInsumoServico servicoInsumo) : base(iMapper, servicoCustoProducaoDetalhe)
    {
      this._iMapper = iMapper;
      this._servicoCustoProducaoDetalhe = servicoCustoProducaoDetalhe;
      this._servicoCompraItem = servicoCompraItem;
      this._servicoSKU = servicoSKU;
      this._servicoInsumo = servicoInsumo;
    }

    private void CalcularValorCusto(ref CustoProducaoDetalheDTO detalhe, bool atualizarValor)
    {
      var sku = _iMapper.Map<SKUDTO>(_servicoSKU.SelectById(detalhe.IdSKU.Value).Result);
      var listaSkuInsumo = _servicoInsumo.Consultar(sku.IdInsumo).Result;
      if (sku != null && sku.Interno)
      {
        var custoProducao = _servicoBase.Listar<CustoProducao>(w => w.IdSKU == sku.Id, i => i.ListaProducaoDetalhe).Result;
        var item = custoProducao.OrderByDescending(o => o.DataCalculo).FirstOrDefault();
        detalhe.CustoAquisicaoItem = item.ListaProducaoDetalhe.Sum(su => su.ValorCustoProducao);
      }
      else
      {
        if (detalhe.CustoAquisicaoItem == 0 || atualizarValor)
        {
          //var compra = _servicoCompraItem..ConsultarUltimaCompra(detalhe.IdSKU).Result;
          detalhe.CustoAquisicaoItem = _servicoCompraItem.ConsultarCustoMedioCompraInsumo(sku.IdInsumo).Result;
        }
      }

      detalhe.SKU = sku;

      TratarCusto(ref detalhe);

      detalhe.SKU = null;
      detalhe.CustoProducao = null;

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

        CalcularValorCusto(ref detalhe, false);

        CustoProducaoDetalhe compraItemBD = await _servicoBase.Consultar<CustoProducaoDetalhe>(w => w.Id == detalhe.Id, i => i.Insumo);
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

    public async Task<ICollection<CustoProducaoDetalheDTO>> AtualizarValoresCusto(Guid IdCustoProducao)
    {      
      var custoProducao = await _servicoCompraItem.Consultar<CustoProducao>(w => w.Id == IdCustoProducao, i => i.ListaProducaoDetalhe);
      ICollection<CustoProducaoDetalheDTO> listaTratada = new HashSet<CustoProducaoDetalheDTO>();
      foreach (var item in custoProducao.ListaProducaoDetalhe)
      {
        CustoProducaoDetalheDTO itemClone = _iMapper.Map<CustoProducaoDetalheDTO>(item);
        CalcularValorCusto(ref itemClone, true);
        listaTratada.Add(itemClone);
      }

      return listaTratada;
    }

    private decimal TratarQtdUnidadeMedida(string unidadeMedida)
    {
      decimal valor = 1;
      switch (unidadeMedida)
      {
        case "G":
          valor = 1000;
          break;
        default:
          break;
      }

      return valor;
    }

    private void TratarCusto(ref CustoProducaoDetalheDTO detalhe)
    {
      detalhe.ValorCustoProducao = ((detalhe.CustoAquisicaoItem * detalhe.qtdUtilizada)).Truncar(2);// / TratarQtdUnidadeMedida(detalhe.SKU.CodigoUnidadeMedida)).Truncar(2);

    }

    public async Task<CustoProducaoDetalhe> PopularDetalhe(CustoProducaoDetalheDTO custoProducaoDetalhe)
    {
      return _iMapper.Map<CustoProducaoDetalhe>(custoProducaoDetalhe);

    }
  }
}
