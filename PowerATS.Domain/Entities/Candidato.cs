using PowerATS.Domain.Entities.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerATS.Domain.Entities
{
    public class Candidato : BaseEntity
    {
        public Candidato() { }

        [Key]
        public Guid IdCandidato { get; set; }
        public string NomeCompleto { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Idade { get; set; }

        [ForeignKey("IdVaga")]
        public virtual ICollection<CandidatoVaga> CandidatoVagas { get; set; } = new List<CandidatoVaga>();

        [ForeignKey("IdCurriculo")]
        public virtual ICollection<Curriculo> Curriculos { get; set; } = new List<Curriculo>();
    }
}