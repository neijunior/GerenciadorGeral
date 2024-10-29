using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Servicos
{
  public interface IInsumoServico : IServicoBase<Insumo>
  {
    Task<Insumo> Consultar(Guid Id);
  }
}
