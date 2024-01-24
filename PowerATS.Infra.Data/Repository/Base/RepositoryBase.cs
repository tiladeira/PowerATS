﻿using Microsoft.EntityFrameworkCore;

using PowerATS.Domain.Entities.Base;
using PowerATS.Domain.Interfaces.Base;
using PowerATS.Infra.Data.Context;

namespace PowerATS.Infra.Data.Repository.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        public readonly AppDbContext _appDbContext;

        public RepositoryBase(AppDbContext appContext)
        {
            _appDbContext = appContext;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _appDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _appDbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _appDbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task DeleteByAsync(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Remove(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Update(entity);
        }
    }
}
