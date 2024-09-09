using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class MenuServico : ServicoBase<Menu>, IMenuServico
  {
    protected readonly IMenuRepositorio _repositorio;
    public MenuServico(IMenuRepositorio repositorio) : base(repositorio)
    {
      this._repositorio = repositorio;
    }

    public Task<ICollection<Menu>> ListarFilhos(Guid IdPai)
    {
      return _repositorio.ListarFilhos(IdPai);
    }

    public Task<ICollection<Menu>> ListarNivelZero()
    {
      return _repositorio.ListarNivelZero();
    }
  }
}
