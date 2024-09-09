using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class CompraApp : AppBase<Compra, CompraDTO>, ICompraApp
  {
    protected readonly ICompraServico _servico;
    protected readonly IMapper _iMapper;
    public CompraApp(IMapper iMapper, ICompraServico servico) : base(iMapper, servico)
    {
      this._iMapper = iMapper;
      this._servico = servico;
    }
  }
}
