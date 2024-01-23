using PowerATS.Domain.Entities.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerATS.Domain.Entities
{
    public class Curriculo : BaseEntity
    {
        [Key]
        public Guid IdCurriculo { get; set; }
        public Guid IdCandidato { get; set; }
        public string CurriculoDocumento { get; set; } = null!;

        [ForeignKey("IdCandidato")]
        public virtual Candidato IdCandidatoNavigation { get; set; } = null!;
    }
}