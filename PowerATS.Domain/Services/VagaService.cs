using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

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

        public async Task DeleteAsync(string id)
        {
            _vagaRepository.Remove(id);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<Vaga>> GetAllAsync()
        {
            return await _vagaRepository.GetAll();
        }

        public async Task<Vaga> GetByIdAsync(string id)
        {
            return await _vagaRepository.GetById(id);
        }

        public async Task UpdateAsync(string id, Vaga entity)
        {
            _vagaRepository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}