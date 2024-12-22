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
    protected readonly ICustoProducaoDetalheServico _servicoCustoProducaoDetalhe;
    protected readonly ICompraItemServico _servicoCompraItem;
    protected readonly IMapper _iMapper;
    public CustoProducaoApp(IMapper iMapper, ICustoProducaoServico servicoCustoProducao, ICompraItemServico servicoCompraItem, ICustoProducaoDetalheServico servicoCustoProducaoDetalhe) : base(iMapper, servicoCustoProducao)
    {
      this._iMapper = iMapper;
      this._servicoCustoProducao = servicoCustoProducao;
      this._servicoCompraItem = servicoCompraItem;
      this._servicoCustoProducaoDetalhe = servicoCustoProducaoDetalhe;
    }

    public async Task<ICollection<CustoProducaoDetalheDTO>> ConsultaCustoPadrao(ICollection<CustoProducaoDetalheDTO> listaItens)
    {

      ICollection<CustoProducaoDetalheDTO> lista = new HashSet<CustoProducaoDetalheDTO>();

      foreach (var item in listaItens)
      {
        var ultimaCompra = await _servicoCompraItem.ConsultarUltimaCompra(item.IdSKU.Value);
        lista.Add(new CustoProducaoDetalheDTO()
        {
          Id = Guid.NewGuid(),
          IdSKU = item.IdSKU,
          QuantidadeUtilizada = item.QuantidadeUtilizada,
          CustoAquisicaoItem = item.CustoAquisicaoItem
        });
      }

      foreach (var item in lista)
      {
        item.ValorCustoProducao = ((item.CustoAquisicaoItem * item.QuantidadeUtilizada) / item.SKU.Quantidade);
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
      var lista = await this._servicoCustoProducao.Listar();
      return _iMapper.Map<ICollection<CustoProducaoDTO>>(lista);

    }

    public async Task<RetornoDTO> Salvar(CustoProducaoDTO custoProducao)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Salvo com sucesso",
        Sucesso = true
      };

      try
      {
        CustoProducao cp = this._servicoCustoProducao.Consultar<CustoProducao>(w => w.Id == custoProducao.Id, i => i.ListaProducaoDetalhe).Result;
        

        bool novo = (cp == null);

        cp = _iMapper.Map<CustoProducao>(custoProducao);

        if (novo)
        {
          
          cp.Id = Guid.NewGuid();
          this._servicoCustoProducao.Insert(cp);
        }
        else
        {
          _servicoCustoProducaoDetalhe.SalvarLista(cp.ListaProducaoDetalhe);
          cp.ListaProducaoDetalhe = null;
          cp.SKU = null;

          this._servicoCustoProducao.Update(cp);
        }


      }
      catch (Exception ex)
      {
        retorno.Mensagem = ex.Message;
        retorno.Sucesso = false;
      }

      return retorno;
    }

  }
}
