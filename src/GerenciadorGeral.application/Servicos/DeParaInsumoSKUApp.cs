using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class DeParaInsumoSKUApp : AppBase<DeParaInsumoSKU, DeParaInsumoSKUDTO>, IDeParaInsumoSKUApp
  {
    protected readonly IDeParaInsumoSKUServico _servico;
    protected readonly IMapper _iMapper;
    public DeParaInsumoSKUApp(IMapper iMapper, IDeParaInsumoSKUServico servico) : base(iMapper, servico)
    {
      this._servico = servico;
      this._iMapper = iMapper;
    }
    
    public async Task<DeParaInsumoSKUDTO> Consultar(Guid Id)
    {
      var resultado = await _servico.Consultar<DeParaInsumoSKU>(w => w.Id == Id);
      return this._iMapper.Map<DeParaInsumoSKUDTO>(resultado);
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

    public async Task<ICollection<DeParaInsumoSKUDTO>> Listar()
    {
      var itens = await this._servico.Listar<DeParaInsumoSKU>(null, i => i.SKU, i => i.Insumo);
      return this._iMapper.Map<ICollection<DeParaInsumoSKUDTO>>(itens);
    }

    public async Task<RetornoDTO> Salvar(DeParaInsumoSKUDTO dePara)
    {
      RetornoDTO retorno = new RetornoDTO()
      {
        Mensagem = "Sucesso",
        Sucesso = true
      };

      try
      {
        DeParaInsumoSKU deParaBD = null;
        var item = await Consultar(dePara.Id);
        if (item == null)
        {
          dePara.Id = Guid.NewGuid();
          deParaBD = new DeParaInsumoSKU();
        }

        deParaBD = _iMapper.Map<DeParaInsumoSKU>(dePara);

        await _servico.Insert(deParaBD);
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
