using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class MenuRepositorio : RepositorioBase<Menu>, IMenuRepositorio
  {
    protected readonly Contexto _contexto;
    public MenuRepositorio(Contexto context) : base(context)
    {
      this._contexto = context;
    }

    public async Task<ICollection<Menu>> ListarFilhos(Guid IdPai)
    {
      return _contexto.Set<Menu>().Where(w => w.IdPai == IdPai).ToList();
    }

    public async Task<ICollection<Menu>> ListarNivelZero()
    {
      return _contexto.Set<Menu>().Where(w => w.Nivel == 0).ToList();
    }
  }
}
