﻿using PowerATS.Domain.Entities.Base;

namespace PowerATS.Domain.Interfaces.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task CreateAsync(TEntity entity);
        Task DeleteByAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}
