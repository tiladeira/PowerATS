using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Infra.Data.Repository.Base;

namespace PowerATS.Infra.Data.Repository
{
    public class CandidatoRepository : RepositoryBaseMongoDB<Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(IMongoContext context) : base(context)
        {

        }
    }
}