using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Repositorios;
using GerenciadorGeral.infra.Data.Contextos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace GerenciadorGeral.infra.Data.Repositorios
{
  public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : EntidadeBase
  {
    protected readonly Contexto _contexto;

    public RepositorioBase(Contexto context) : base()
    {
      this._contexto = context;
    }

    public async Task Update(TEntity entity)
    {
      try
      {
        _contexto.InitTransaction();
        _contexto.Set<TEntity>().Attach(entity);
        _contexto.Entry(entity).State = EntityState.Modified;
        _contexto.SendChanges();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public async Task Delete(Guid Id)
    {
      var entity = await SelectById(Id);
      if (entity != null)
      {
        _contexto.InitTransaction();
        _contexto.Set<TEntity>().Remove(entity);
        _contexto.SendChanges();
      }
    }

    public async Task Delete(TEntity entity)
    {
      _contexto.InitTransaction();
      _contexto.Set<TEntity>().Remove(entity);
      _contexto.SendChanges();
    }

    public async Task Insert(TEntity entity)
    {
      _contexto.InitTransaction();
      var id = _contexto.Set<TEntity>().Add(entity).Entity.Id;
      _contexto.SendChanges();
      //return id;
    }

    public async Task<ICollection<TEntity>> SelectAll()
    {
      return _contexto.Set<TEntity>().ToList();
    }

    public async Task<TEntity> SelectById(Guid Id)
    {
      return _contexto.Set<TEntity>().Find(Id);
    }

    public async Task<TEntity> Consultar<TEntity>(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes) where TEntity : class
    {
      try
      {
        IQueryable<TEntity> query = _contexto.Set<TEntity>();
        foreach (Expression<Func<TEntity, object>> inc in includes)
          query = query.Include(inc);

        return query.FirstOrDefault(where);
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

    public async Task<TEntity> ConsultarUltimo<TEntity>(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes) where TEntity : class
    {
      try
      {
        IQueryable<TEntity> query = _contexto.Set<TEntity>();
        foreach (Expression<Func<TEntity, object>> inc in includes)
          query = query.Include(inc);

        return query.LastOrDefault(where);
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

    public async Task<ICollection<TEntity>> Listar<TEntity>(Func<TEntity, bool> where = default, params Expression<Func<TEntity, object>>[] includes) where TEntity : class
    {
      try
      {
        IQueryable<TEntity> query = _contexto.Set<TEntity>();
        foreach (Expression<Func<TEntity, object>> inc in includes)
          query = query.Include(inc);

        if (where != null)
        {
          return query.Where(where).ToList();
        }
        return query.ToList<TEntity>();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public async Task<ICollection<R>> Listar<TEntity, R>(Func<TEntity, bool> where, Func<TEntity, R> select = default, params Expression<Func<TEntity, object>>[] includes) where TEntity : class
    {
      try
      {
        IQueryable<TEntity> query = _contexto.Set<TEntity>();
        foreach (Expression<Func<TEntity, object>> inc in includes)
          query = query.Include(inc);

        if (where != null)
          return query.Where(where).Select(select).ToList<R>();
        return query.Select(select).ToList<R>();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
