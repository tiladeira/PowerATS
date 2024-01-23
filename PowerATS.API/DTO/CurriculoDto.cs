using System.ComponentModel.DataAnnotations;

namespace PowerATS.API.DTO
{
    public class CurriculoDto 
    {
        public Guid id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid IdCurriculo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid IdCandidato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string CurriculoDocumento { get; set; } = null!;
    }
}
