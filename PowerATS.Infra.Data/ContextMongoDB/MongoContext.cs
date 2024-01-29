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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vaga>();
        }
    }
}
