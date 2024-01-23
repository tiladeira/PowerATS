using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Infra.Data.Context;

namespace PowerATS.Infra.Data.UnitOfWork
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly AppDbContext _dbContext;

        public ICandidatoRepository Candidato { get; }
        public ICandidatoVagaRepository CandidatoVaga { get; }
        public ICurriculoRepository Curriculo { get; }
        public IVagaRepository Vaga { get; }

        public UnitOfWorkRepository(AppDbContext dbContext,
                                    ICandidatoRepository candidato,
                                    ICandidatoVagaRepository candidatoVaga,
                                    ICurriculoRepository curriculo,
                                    IVagaRepository vaga)
        {
            _dbContext = dbContext;
            Candidato = candidato;
            CandidatoVaga = candidatoVaga;
            Curriculo = curriculo;
            Vaga = vaga;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Rollback()
        {
            _dbContext.Dispose();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task RollbackAsync()
        {
            await _dbContext.DisposeAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _dbContext.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
