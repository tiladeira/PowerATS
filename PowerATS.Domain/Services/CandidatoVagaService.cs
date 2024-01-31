using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.Domain.Services
{
    public class CandidatoVagaService : ICandidatoVagaService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        private readonly ICandidatoVagaRepository _candidatoVagaRepository;

        public CandidatoVagaService(ICandidatoVagaRepository candidatoVagaRepository, IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _candidatoVagaRepository = candidatoVagaRepository;
        }

        public async Task AddAsync(CandidatoVaga entity)
        {
            if (entity != null)
            {
                _candidatoVagaRepository.Add(entity);
                _unitOfWork.Commit();
            }
        }

        public async Task DeleteAsync(string id)
        {
            _candidatoVagaRepository.Remove(id);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<CandidatoVaga>> GetAllAsync()
        {
            return await _candidatoVagaRepository.GetAll();
        }

        public async Task<CandidatoVaga> GetByIdAsync(string id)
        {
            return await _candidatoVagaRepository.GetById(id);
        }

        public async Task UpdateAsync(string id, CandidatoVaga entity)
        {
            _candidatoVagaRepository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}