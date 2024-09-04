using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class CompraApp : ServicoAppBase<Compra, CompraDTO>, ICompraApp
  {
    public CompraApp(IMapper iMapper, ICompraServico servico) : base(iMapper, servico)
    {
    }
  }
}
