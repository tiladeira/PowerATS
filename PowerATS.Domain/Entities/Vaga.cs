using PowerATS.Domain.Entities.Base;
using PowerATS.Domain.Enums;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerATS.Domain.Entities
{
    public class Vaga : BaseEntity
    {
        [Key]
        public Guid IdVaga { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public decimal Valor { get; set; }
        public EnumTipoContratacao? TipoContratacao { get; set; }
        public bool? Status { get; set; }

        [ForeignKey("IdCandidato")]
        public virtual ICollection<CandidatoVaga> CandidatoVagas { get; set; } = new List<CandidatoVaga>();
    }
}