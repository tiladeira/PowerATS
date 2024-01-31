using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using PowerATS.Domain.Interfaces.Repositories;
using PowerATS.Domain.Interfaces.Services;
using PowerATS.Domain.Services;
using PowerATS.Infra.Data.ContextMongoDB;
using PowerATS.Infra.Data.Repository;
using PowerATS.Infra.Data.UnitOfWork;

using System;

namespace PowerATS.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddTransient<IMongoContext, MongoContext>();

            services.AddTransient<IUnitOfWorkRepository, UnitOfWorkRepository>();
            services.AddTransient<ICandidatoRepository, CandidatoRepository>();
            services.AddTransient<ICandidatoVagaRepository, CandidatoVagaRepository>();
            services.AddTransient<ICurriculoRepository, CurriculoRepository>();
            services.AddTransient<IVagaRepository, VagaRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICandidatoService, CandidatoService>();
            services.AddTransient<ICandidatoVagaService, CandidatoVagaService>();
            services.AddTransient<ICurriculoService, CurriculoService>();
            services.AddTransient<IVagaService, VagaService>();

            return services;
        }
    }
}
