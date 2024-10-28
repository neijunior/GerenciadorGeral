using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System.Text.RegularExpressions;

namespace GerenciadorGeral.application.Servicos
{
  public class InsumoApp : AppBase<Insumo, InsumoDTO>, IInsumoApp
  {
    protected readonly IInsumoServico _servico;
    protected readonly IMapper _iMapper;

    public InsumoApp(IMapper iMapper, IInsumoServico servico) : base(iMapper, servico)
    {
      this._servico = servico;
      this._iMapper = iMapper;
    }

    public async Task<InsumoDTO> Consultar(Guid Id)
    {
      var resultado = await _servico.Consultar<Insumo>(w => w.Id == Id);
      return this._iMapper.Map<InsumoDTO>(resultado);
    }

    public async Task<RetornoDTO> Excluir(Guid Id)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Sucesso",
        Sucesso = true
      };

      try
      {
        await _servico.Delete(Id);
      }
      catch (Exception ex)
      {
        retorno.Sucesso = false;
        retorno.Mensagem = ex.Message;
      }


      return retorno;
    }

    public async Task<ICollection<InsumoDTO>> Listar()
    {
      var itens = await this._servico.Listar<Insumo>(null);
      return this._iMapper.Map<ICollection<InsumoDTO>>(itens);
    }

    public async Task<RetornoDTO> Salvar(InsumoDTO insumo)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Sucesso",
        Sucesso = true
      };

      try
      {
        Insumo insumoBD = null;
        var item = await Consultar(insumo.Id);
        if (item == null)
        {
          insumo.Id = Guid.NewGuid();
          insumoBD = new Insumo();          
        }

        insumoBD = _iMapper.Map<Insumo>(insumo);

        await _servico.Insert(insumoBD);
      }
      catch (Exception ex)
      {
        retorno.Sucesso = false;
        retorno.Mensagem = ex.Message;
      }


      return retorno;
    }
  }
}
