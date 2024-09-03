using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class SKUApp : ServicoAppBase<SKU, SKUDTO>, ISKUApp
  {
    public SKUApp(IMapper iMapper, ISKUServico servico) : base(iMapper, servico)
    {
    }
  }
}
