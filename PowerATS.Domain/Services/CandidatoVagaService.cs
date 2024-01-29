using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

using System.Linq.Expressions;

namespace PowerATS.Domain.Services
{
    public class CandidatoVagaService : ICandidatoVagaService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public CandidatoVagaService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddAsync(CandidatoVaga entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CandidatoVaga>> FindAsync(Expression<Func<CandidatoVaga, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CandidatoVaga>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CandidatoVaga> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, CandidatoVaga entity)
        {
            throw new NotImplementedException();
        }
    }
}