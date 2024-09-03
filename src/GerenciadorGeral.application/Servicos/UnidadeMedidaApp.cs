using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class UnidadeMedidaApp : ServicoAppBase<UnidadeMedida, UnidadeMedidaDTO>, IUnidadeMedidaApp
  {
    public UnidadeMedidaApp(IMapper iMapper, IUnidadeMedidaServico servico) : base(iMapper, servico)
    {
    }
  }
}
