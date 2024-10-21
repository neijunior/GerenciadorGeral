using GerenciadorGeral.domain.Entidades;
using System.Linq.Expressions;

namespace GerenciadorGeral.domain.Interfaces.Repositorios
{
  public interface IRepositorioBase<TEntity> where TEntity : EntidadeBase
  {
    Task Insert(TEntity entity);
    Task Delete(Guid Id);
    Task Delete(TEntity entity);
    Task Update(TEntity entity);
    Task<TEntity> SelectById(Guid Id);
    Task<ICollection<TEntity>> SelectAll();
    Task<TEntity> Consultar<TEntity>(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes) where TEntity : class;
    Task<TEntity> ConsultarUltimo<TEntity>(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes) where TEntity : class;
    Task<ICollection<TEntity>> Listar<TEntity>(Func<TEntity, bool> where = null, params Expression<Func<TEntity, object>>[] includes) where TEntity : class;
    //Task<ICollection<R>> Listar<TEntity, R>(Func<TEntity, bool> where, Func<TEntity, R> select = null, params Expression<Func<TEntity, object>>[] includes) where TEntity : class;
  }
}
