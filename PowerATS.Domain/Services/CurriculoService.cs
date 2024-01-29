using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

using System.Linq.Expressions;

namespace PowerATS.Domain.Services
{
    public class CurriculoService : ICurriculoService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public CurriculoService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddAsync(Curriculo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Curriculo>> FindAsync(Expression<Func<Curriculo, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Curriculo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Curriculo> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, Curriculo entity)
        {
            throw new NotImplementedException();
        }
    }
}