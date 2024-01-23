using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.Domain.Services
{
    public class CandidatoVagaService : ICandidatoVagaService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public CandidatoVagaService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(CandidatoVaga entity)
        {
            if (entity != null)
            {
                entity.IdCandidatoVaga = Guid.NewGuid();
                entity.id = Guid.NewGuid();

                await _unitOfWork.CandidatoVaga.CreateAsync(entity);
                var result = _unitOfWork.Commit();

                if (result > 0)
                    return true;
                else
                    return false;
            }

            return false;
        }

        public async Task<bool> DeleteByIdAsync(Guid id)
        {
            if (id != null)
            {
                var entity = await _unitOfWork.CandidatoVaga.GetByIdAsync(id);

                if (entity != null)
                {
                    await _unitOfWork.CandidatoVaga.DeleteByAsync(entity).ConfigureAwait(false);
                    var result = _unitOfWork.Commit();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        public async Task<IEnumerable<CandidatoVaga>> GetAllAsync()
        {
            return await _unitOfWork.CandidatoVaga.GetAllAsync();
        }

        public async Task<CandidatoVaga> GetByIdAsync(Guid id)
        {
            if (id != null)
            {
                var entity = await _unitOfWork.CandidatoVaga.GetByIdAsync(id);

                if (entity != null)
                    return entity;
            }

            return null;
        }

        public async Task<bool> UpdateAsync(CandidatoVaga entity)
        {
            if (entity != null)
            {
                await _unitOfWork.CandidatoVaga.UpdateAsync(entity);
                var result = _unitOfWork.Commit();

                if (result > 0)
                    return true;
                else
                    return false;
            }

            return false;
        }
    }
}