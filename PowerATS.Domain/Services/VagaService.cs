using PowerATS.Domain.Entities;
using PowerATS.Domain.Enums;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

using System.Linq.Expressions;

namespace PowerATS.Domain.Services
{
    public class VagaService : IVagaService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        private readonly IVagaRepository _vagaRepository;

        public VagaService(IVagaRepository vagaRepository, IUnitOfWorkRepository unitOfWork)
        {
            _vagaRepository = vagaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(Vaga entity)
        {
            if (entity != null)
            {
                 _vagaRepository.Add(entity);
                _unitOfWork.Commit();
            }
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vaga>> FindAsync(Expression<Func<Vaga, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Vaga>> GetAllAsync()
        {
            return await _vagaRepository.GetAll();
        }

        public Task<Vaga> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string id, Vaga entity)
        {
            throw new NotImplementedException();
        }
    }
}