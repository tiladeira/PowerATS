using PowerATS.Domain.Entities;
using PowerATS.Domain.Enums;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;

namespace PowerATS.Domain.Services
{
    public class VagaService : IVagaService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public VagaService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(Vaga entity)
        {
            if (entity != null)
            {
                entity.IdVaga = Guid.NewGuid();
                entity.id = Guid.NewGuid();
                entity.TipoContratacao = EnumTipoContratacao.CLT;
                entity.Status = true;

                await _unitOfWork.Vaga.CreateAsync(entity);
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
                var entity = await _unitOfWork.Vaga.GetByIdAsync(id);

                if (entity != null)
                {
                    await _unitOfWork.Vaga.DeleteByAsync(entity).ConfigureAwait(false);
                    var result = _unitOfWork.Commit();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        public async Task<IEnumerable<Vaga>> GetAllAsync()
        {
            return await _unitOfWork.Vaga.GetAllAsync();
        }

        public async Task<Vaga> GetByIdAsync(Guid id)
        {
            if (id != null)
            {
                var entity = await _unitOfWork.Vaga.GetByIdAsync(id);

                if (entity != null)
                    return entity;
            }

            return null;
        }

        public async Task<bool> UpdateAsync(Vaga entity)
        {
            if (entity != null)
            {
                entity.TipoContratacao = EnumTipoContratacao.CLT;
                entity.Status = true;

                await _unitOfWork.Vaga.UpdateAsync(entity);
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