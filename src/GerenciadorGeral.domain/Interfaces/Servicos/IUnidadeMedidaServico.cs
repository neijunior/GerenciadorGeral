using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Servicos
{
  public interface IUnidadeMedidaServico
  {
    Task<ICollection<UnidadeMedida>> SelectAll();
  }
}
