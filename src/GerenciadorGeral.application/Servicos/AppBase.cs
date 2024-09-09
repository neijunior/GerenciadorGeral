using AutoMapper;
using GerenciadorGeral.application.DTO;
using GerenciadorGeral.application.Interfaces;
using GerenciadorGeral.domain.Entidades;
using GerenciadorGeral.domain.Interfaces.Servicos;
using System.Linq.Expressions;

namespace GerenciadorGeral.application.Servicos
{
  public class AppBase<TEntity, TEntidadeDTO> : IAppBase<TEntity, TEntidadeDTO>
      where TEntity : EntidadeBase
      where TEntidadeDTO : BaseDTO
  {
    public readonly IServicoBase<TEntity> _servicoBase;
    public readonly IMapper _iMapperBase;

    public AppBase(IMapper iMapper, IServicoBase<TEntity> servico) : base()
    {
      this._iMapperBase = iMapper;
      this._servicoBase = servico;
    }
    public async Task Delete(Guid Id)
    {
      await _servicoBase.Delete(Id);
    }

    public async Task Delete(TEntity entity)
    {
      await _servicoBase.Delete(entity);
    }

    public async Task Insert(TEntity entity)
    {
      await _servicoBase.Insert(_iMapperBase.Map<TEntity>(entity));
    }

    public async Task<ICollection<TEntidadeDTO>> SelectAll()
    {
      var lista = _iMapperBase.Map<ICollection<TEntidadeDTO>>(await _servicoBase.SelectAll());
      return lista;
    }

    public async Task<TEntidadeDTO> SelectById(Guid Id)
    {
      return _iMapperBase.Map<TEntidadeDTO>(await _servicoBase.SelectById(Id));
    }

    
    public async Task<TEntidadeDTO> Consultar<TEntity>(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includes) where TEntity : class
    {
      var item = await _servicoBase.Consultar(where, includes);
      return _iMapperBase.Map<TEntidadeDTO>(item);
    }

    public async Task Update(TEntity entity)
    {
      await _servicoBase.Update(_iMapperBase.Map<TEntity>(entity));
    }
  }
}
