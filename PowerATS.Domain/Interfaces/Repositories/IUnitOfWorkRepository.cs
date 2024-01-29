namespace PowerATS.Domain.Interfaces.Repositories
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        Task<bool> Commit();
    }
}
