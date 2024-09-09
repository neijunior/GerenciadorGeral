using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Servicos
{
  public interface IMenuServico  : IServicoBase<Menu>
  {
    Task<ICollection<Menu>> ListarFilhos(Guid IdPai);
    Task<ICollection<Menu>> ListarNivelZero();
  }
}
