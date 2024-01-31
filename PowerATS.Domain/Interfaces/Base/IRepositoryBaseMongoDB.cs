namespace PowerATS.Domain.Interfaces.Base
{
    public interface IRepositoryBaseMongoDB<T> where T : class
    {
        void Add(T obj);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        void Update(T obj);
        void Remove(int id);
    }
}
