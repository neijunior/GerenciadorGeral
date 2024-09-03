using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.domain.Interfaces.Servicos;

namespace GerenciadorGeral.domain.Servicos
{
  public class ServicoBase<TEntity> : IServicoBase<TEntity> where TEntity : EntidadeBase
  {
    protected readonly IRepositorioBase<TEntity> _repositorio;
    public ServicoBase(IRepositorioBase<TEntity> repositorio)
    {
      this._repositorio = repositorio;
    }
    public async Task Delete(Guid Id)
    {
      await _repositorio.Delete(Id);
    }

    public async Task Delete(TEntity entity)
    {
      await _repositorio.Delete(entity);
    }

    public async Task Insert(TEntity entity)
    {
      await _repositorio.Insert(entity);
    }

    public async Task<ICollection<TEntity>> SelectAll()
    {
      return await _repositorio.SelectAll();
    }

    public async Task<TEntity> SelectById(Guid Id)
    {
      return await _repositorio.SelectById(Id);
    }

    public async Task Update(TEntity entity)
    {
      await _repositorio.Update(entity);
    }
  }
}
