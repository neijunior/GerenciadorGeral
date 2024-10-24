using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class UsuarioApp : AppBase<Usuario, UsuarioDTO>, IUsuarioApp
  {
    protected readonly IUsuarioServico _servico;
    protected readonly IMapper _iMapper;
    public UsuarioApp(IMapper iMapper, IUsuarioServico servico) : base(iMapper, servico)
    {
      this._iMapper = iMapper;
      this._servico = servico;
    }

    //public async Task<UsuarioDTO> Consultar(Guid Id)
    //{
    //  var item = await this._servico.Consultar(Id);

    //  return this._iMapper.Map<UsuarioDTO>(item);  

    //}

    public async Task<ICollection<UsuarioDTO>> Listar()
    {
      var itens = await this._servico.Listar<Usuario>();
      return this._iMapper.Map<ICollection<UsuarioDTO>>(itens);
    }
  }
}
