using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.Domain.Services
{
    public class CurriculoService : ICurriculoService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        private readonly ICurriculoRepository _curriduloRepository;

        public CurriculoService(ICurriculoRepository curriduloRepository, IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _curriduloRepository = curriduloRepository;
        }

        public async Task AddAsync(Curriculo entity)
        {
            if (entity != null)
            {
                _curriduloRepository.Add(entity);
                _unitOfWork.Commit();
            }
        }

        public async Task DeleteAsync(string id)
        {
            _curriduloRepository.Remove(id);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<Curriculo>> GetAllAsync()
        {
            return await _curriduloRepository.GetAll();
        }

        public async Task<Curriculo> GetByIdAsync(string id)
        {
            return await _curriduloRepository.GetById(id);
        }

        public async Task UpdateAsync(string id, Curriculo entity)
        {
            _curriduloRepository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}