using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Infra.Data.Context;

using PowerATS.Infra.Data.Repository.Base;

namespace PowerATS.Infra.Data.Repository
{
    public class CandidatoRepository : RepositoryBase<Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(AppDbContext appContext) : base(appContext)
        {

        }
    }
}