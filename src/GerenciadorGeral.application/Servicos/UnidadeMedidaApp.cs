using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
    public class UnidadeMedidaApp : IUnidadeMedidaApp      
  {
    public readonly IUnidadeMedidaServico _servico;
    public readonly IMapper _iMapper;
    public UnidadeMedidaApp(IMapper iMapper, IUnidadeMedidaServico servico) : base()
    {
      this._iMapper = iMapper;
      this._servico = servico;
    }

    public async Task<ICollection<UnidadeMedidaDTO>> SelectAll()
    {
      var lista = _iMapper.Map<ICollection<UnidadeMedidaDTO>>(await _servico.SelectAll());
      return lista;
    }
  }
}
