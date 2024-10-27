using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.application.Servicos
{
  public class InsumoApp : AppBase<Insumo, InsumoDTO>, IInsumoApp
  {
    public InsumoApp(IMapper iMapper, IInsumoServico servico) : base(iMapper, servico)
    {
    }
  }
}
