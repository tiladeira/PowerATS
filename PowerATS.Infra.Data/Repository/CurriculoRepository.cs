using PowerATS.Domain.Entities;
using PowerATS.Domain.Interfaces.Repositories;

using PowerATS.Infra.Data.Repository.Base;

namespace PowerATS.Infra.Data.Repository
{
    public class CurriculoRepository : RepositoryBaseMongoDB<Curriculo>, ICurriculoRepository
    {
        public CurriculoRepository(IMongoContext context) : base(context)
        {

        }
    }
}