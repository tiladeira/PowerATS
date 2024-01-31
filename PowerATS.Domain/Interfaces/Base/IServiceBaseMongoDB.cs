using System.Linq.Expressions;

namespace PowerATS.Domain.Interfaces.Base
{
    public interface IServiceBaseMongoDB<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task AddAsync(T entity);
        Task UpdateAsync(string id, T entity);
        Task DeleteAsync(string id);
    }
}
