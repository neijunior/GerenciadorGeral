using GerenciadorGeral.domain.Entidades;

namespace GerenciadorGeral.domain.Interfaces.Servicos
{
    public interface IServicoBase<TEntity> where TEntity : EntidadeBase
    {
        Task Insert(TEntity entity);
        Task Delete(int Id);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
        Task<TEntity> SelectById(int Id);
        Task<ICollection<TEntity>> SelectAll();
    }
}
