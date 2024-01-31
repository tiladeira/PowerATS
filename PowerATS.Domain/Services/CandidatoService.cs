using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.Domain.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoService(ICandidatoRepository candidatoRepository, IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _candidatoRepository = candidatoRepository;
        }

        public async Task AddAsync(Candidato entity)
        {
            if (entity != null)
            {
                _candidatoRepository.Add(entity);
                _unitOfWork.Commit();
            }
        }

        public async Task DeleteAsync(string id)
        {
            _candidatoRepository.Remove(id);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<Candidato>> GetAllAsync()
        {
            return await _candidatoRepository.GetAll();
        }

        public async Task<Candidato> GetByIdAsync(string id)
        {
            return await _candidatoRepository.GetById(id);
        }

        public async Task UpdateAsync(string id, Candidato entity)
        {
            _candidatoRepository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}