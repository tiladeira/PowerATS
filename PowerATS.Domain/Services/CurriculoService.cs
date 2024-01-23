using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.Domain.Services
{
    public class CurriculoService : ICurriculoService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public CurriculoService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(Curriculo entity)
        {
            if (entity != null)
            {
                entity.IdCurriculo = Guid.NewGuid();
                entity.id = Guid.NewGuid();

                await _unitOfWork.Curriculo.CreateAsync(entity);
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
                var entity = await _unitOfWork.Curriculo.GetByIdAsync(id);

                if (entity != null)
                {
                    await _unitOfWork.Curriculo.DeleteByAsync(entity).ConfigureAwait(false);
                    var result = _unitOfWork.Commit();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        public async Task<IEnumerable<Curriculo>> GetAllAsync()
        {
            return await _unitOfWork.Curriculo.GetAllAsync();
        }

        public async Task<Curriculo> GetByIdAsync(Guid id)
        {
            if (id != null)
            {
                var entity = await _unitOfWork.Curriculo.GetByIdAsync(id);

                if (entity != null)
                    return entity;
            }

            return null;
        }

        public async Task<bool> UpdateAsync(Curriculo entity)
        {
            if (entity != null)
            {
                await _unitOfWork.Curriculo.UpdateAsync(entity);
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