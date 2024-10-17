using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class CompraItemApp : AppBase<CompraItem, CompraItemDTO>, ICompraItemApp
  {
    protected readonly ICompraItemServico _servico;
    protected readonly ICompraServico _servicoCompra;
    protected readonly IMapper _iMapper;
    public CompraItemApp(IMapper iMapper, ICompraItemServico servico, ICompraServico servicoCompra) : base(iMapper, servico)
    {
      this._iMapper = iMapper;
      this._servico = servico;
      this._servicoCompra = servicoCompra;
    }

    public async Task<RetornoDTO> AtualizarDadosCompra(CompraItem compraItem)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Atualizado com sucesso",
        Sucesso = true
      };
      try
      {
        Compra compra = await _servicoCompra.Consultar(compraItem.IdCompra);

        compra.ValorTotal = compra.ListaItens.Sum(su => su.ValorTotal);

        compra.ListaItens = null;
        compra.Fornecedor = null;

        await _servicoCompra.Update(compra);
      }
      catch (Exception ex)
      {
        retorno.Mensagem = ex.Message;
        retorno.Sucesso = false;
      }

      return retorno;
    }

    public async Task<RetornoDTO> Salvar(CompraItem compraItem)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Atualizado com sucesso",
        Sucesso = true
      };

      try
      {
        CompraItem compraItemBD = await _servico.Consultar<CompraItem>(w => w.Id == compraItem.Id);
        if (compraItemBD == null)
          await _servicoBase.Insert(compraItem);
        else
          await _servicoBase.Update(compraItem);

        await AtualizarDadosCompra(compraItem);

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
