using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;

using PowerATS.Infra.Data.Repository.Base;

namespace PowerATS.Infra.Data.Repository
{
    public class CandidatoVagaRepository : RepositoryBaseMongoDB<CandidatoVaga>, ICandidatoVagaRepository
    {
        public CandidatoVagaRepository(IMongoContext context) : base(context)
        {

        }
    }
}