using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;
using System.Linq.Expressions;

namespace GerenciadorGeral.application.Interfaces
{
  public interface IAppBase<TEntity, TEntityDTO> where TEntity : EntidadeBase
                                                 where TEntityDTO : BaseDTO
  {
    Task Insert(TEntity entity);
    Task Delete(Guid Id);
    Task Delete(TEntity entity);
    Task Update(TEntity entity);
    Task<TEntityDTO> SelectById(Guid Id);    
    Task<ICollection<TEntityDTO>> SelectAll();
    Task<TEntityDTO> Consultar<TEntity>(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes) where TEntity : class;
    Task<ICollection<TEntityDTO>> Listar<TEntity>(Func<TEntity, bool> where = null, params Expression<Func<TEntity, object>>[] includes) where TEntity : class;
    //Task<ICollection<R>> Listar<TEntity, R>(Func<TEntity, bool> where, Func<TEntity, R> select = null, params Expression<Func<TEntity, object>>[] includes) where TEntity : class;
  }
}
