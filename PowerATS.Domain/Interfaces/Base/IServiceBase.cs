using PowerATS.Domain.Entities.Base;

namespace PowerATS.Domain.Interfaces.Base
{
    public interface IServiceBase<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(TEntity entity);
        Task<bool> DeleteByIdAsync(Guid id);
        Task<bool> UpdateAsync(TEntity entity);
    }
}
