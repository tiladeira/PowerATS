using PowerATS.Domain.Entities.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerATS.Domain.Entities
{
    public class CandidatoVaga : BaseEntity
    {
        public CandidatoVaga() { }

        [Key]
        public Guid IdCandidatoVaga { get; set; }
        public Guid IdCandidato { get; set; }
        public Guid IdVaga { get; set; }


        [ForeignKey("IdCandidato")]
        public virtual Candidato IdCandidatoNavigation { get; set; } = null!;

        [ForeignKey("IdVaga")]
        public virtual Vaga IdVagaNavigation { get; set; } = null!;
    }
}