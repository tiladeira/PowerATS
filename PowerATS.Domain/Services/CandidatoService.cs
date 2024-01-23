using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.Domain.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public CandidatoService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(Candidato entity)
        {
            if (entity != null)
            {
                entity.IdCandidato = Guid.NewGuid();
                entity.id = Guid.NewGuid();

                await _unitOfWork.Candidato.CreateAsync(entity);
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
                var entity = await _unitOfWork.Candidato.GetByIdAsync(id);

                if (entity != null)
                {
                    await _unitOfWork.Candidato.DeleteByAsync(entity).ConfigureAwait(false);
                    var result = _unitOfWork.Commit();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        public async Task<IEnumerable<Candidato>> GetAllAsync()
        {
            return await _unitOfWork.Candidato.GetAllAsync();
        }

        public async Task<Candidato> GetByIdAsync(Guid id)
        {
            if (id != null)
            {
                var entity = await _unitOfWork.Candidato.GetByIdAsync(id);

                if (entity != null)
                    return entity;
            }

            return null;
        }

        public async Task<bool> UpdateAsync(Candidato entity)
        {
            if (entity != null)
            {
                await _unitOfWork.Candidato.UpdateAsync(entity);
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