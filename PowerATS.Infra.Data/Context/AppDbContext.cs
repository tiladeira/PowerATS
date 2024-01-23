using Microsoft.EntityFrameworkCore;

using PowerATS.Domain.Entities;

namespace PowerATS.Infra.Data.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<CandidatoVaga> CandidastoVagas { get; set; }
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidato>(entity =>
            {
                entity.HasKey(e => e.IdCandidato);

                entity.ToTable("Candidato");

                entity.Property(e => e.IdCandidato).ValueGeneratedNever();
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.NomeCompleto)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CandidatoVaga>(entity =>
            {
                entity.HasKey(e => e.IdCandidatoVaga);

                entity.ToTable("CandidatoVaga");

                entity.Property(e => e.IdCandidatoVaga).ValueGeneratedNever();

                entity.HasOne(d => d.IdCandidatoNavigation).WithMany(p => p.CandidatoVagas)
                    .HasForeignKey(d => d.IdCandidato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidatoVaga_Candidato");

                entity.HasOne(d => d.IdVagaNavigation).WithMany(p => p.CandidatoVagas)
                    .HasForeignKey(d => d.IdVaga)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CandidatoVaga_Vaga");
            });

            modelBuilder.Entity<Curriculo>(entity =>
            {
                entity.HasKey(e => e.IdCurriculo);

                entity.ToTable("Curriculo");

                entity.Property(e => e.IdCurriculo).ValueGeneratedNever();
                entity.Property(e => e.CurriculoDocumento).HasColumnName("Curriculo");

                entity.HasOne(d => d.IdCandidatoNavigation).WithMany(p => p.Curriculos)
                    .HasForeignKey(d => d.IdCandidato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Curriculo_Candidato");
            });

            modelBuilder.Entity<Vaga>(entity =>
            {
                entity.HasKey(e => e.IdVaga);

                entity.ToTable("Vaga");

                entity.Property(e => e.IdVaga).ValueGeneratedNever();
                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
