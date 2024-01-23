namespace PowerATS.Domain.Interfaces.Repositories
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        public ICandidatoRepository Candidato { get; }
        public ICandidatoVagaRepository CandidatoVaga { get; }
        public ICurriculoRepository Curriculo { get; }
        public IVagaRepository Vaga { get; }

        int Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
