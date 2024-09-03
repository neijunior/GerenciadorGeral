﻿using GerenciadorGeral.application.DTO;
using GerenciadorGeral.domain.Entidades;

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
    }
}
