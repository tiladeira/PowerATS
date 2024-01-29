using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;
using PowerATS.Domain.Services;
using PowerATS.Infra.Data.ContextMongoDB;
using PowerATS.Infra.Data.Repository;
using PowerATS.Infra.Data.UnitOfWork;

namespace PowerATS.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMongoContext, MongoContext>();
            services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();
            services.AddScoped<ICandidatoRepository, CandidatoRepository>();
            services.AddScoped<ICandidatoVagaRepository, CandidatoVagaRepository>();
            services.AddScoped<ICurriculoRepository, CurriculoRepository>();
            services.AddScoped<IVagaRepository, VagaRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICandidatoService, CandidatoService>();
            services.AddScoped<ICandidatoVagaService, CandidatoVagaService>();
            services.AddScoped<ICurriculoService, CurriculoService>();
            services.AddScoped<IVagaService, VagaService>();

            return services;
        }
    }
}
