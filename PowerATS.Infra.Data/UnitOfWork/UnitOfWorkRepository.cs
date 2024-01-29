using PowerATS.Domain.Interfaces.Repositories;

namespace PowerATS.Infra.Data.UnitOfWork
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly IMongoContext _context;

        public UnitOfWorkRepository(IMongoContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            var changeAmount = await _context.SaveChanges();

            return changeAmount > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
