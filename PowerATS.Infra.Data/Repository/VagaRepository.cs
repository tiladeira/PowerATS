using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;

using PowerATS.Infra.Data.Repository.Base;

namespace PowerATS.Infra.Data.Repository
{
    public class VagaRepository : RepositoryBaseMongoDB<Vaga>, IVagaRepository
    {
        public VagaRepository(IMongoContext context) : base(context)
        {

        }
    }
}