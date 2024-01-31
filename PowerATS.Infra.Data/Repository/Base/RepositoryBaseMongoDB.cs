using MongoDB.Driver;

using PowerATS.Domain.Interfaces.Base;
using PowerATS.Domain.Interfaces.Repositories;

namespace PowerATS.Infra.Data.Repository.Base
{
    public class RepositoryBaseMongoDB<T> : IRepositoryBaseMongoDB<T> where T : class
    {
        protected readonly IMongoContext context;
        protected IMongoCollection<T> _collection;

        public RepositoryBaseMongoDB(IMongoContext context)
        {
            this.context = context;
            _collection = context.GetCollection<T>(typeof(T).Name);
        }

        public virtual void Add(T obj)
        {
            context.AddCommand(() => _collection.InsertOneAsync(obj));
        }

        public virtual async Task<T> GetById(string id)
        {
            var data = await _collection.FindAsync(Builders<T>.Filter.Eq("_id", id));
            return data.SingleOrDefault();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            var all = await _collection.FindAsync(Builders<T>.Filter.Empty);
            return all.ToList();
        }

        public virtual void Update(T obj)
        {
            context.AddCommand(() => _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", obj.GetType()), obj));
        }

        public virtual void Remove(string id)
        {
            context.AddCommand(() => _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", id)));
        }

        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
