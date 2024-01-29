using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

using System.Linq.Expressions;

namespace PowerATS.Domain.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public CandidatoService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddAsync(Candidato entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Candidato>> FindAsync(Expression<Func<Candidato, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Candidato>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Candidato> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, Candidato entity)
        {
            throw new NotImplementedException();
        }
    }
}