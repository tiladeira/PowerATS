using Microsoft.EntityFrameworkCore;

using PowerATS.Domain.Entities;

namespace PowerATS.Infra.Data.ContextMongoDB
{
    public class MongoContext : DbContext
    {
        public MongoContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<Vaga> Vagas { get; init; }
        public DbSet<Candidato> Candidatos { get; init; }
        public DbSet<CandidatoVaga> CandidatosVagas { get; init; }
        public DbSet<Curriculo> Curriculos { get; init; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vaga>();
            modelBuilder.Entity<Candidato>();
            modelBuilder.Entity<CandidatoVaga>();
            modelBuilder.Entity<Curriculo>();
        }
    }
}
