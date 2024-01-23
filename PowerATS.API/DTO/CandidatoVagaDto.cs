using System.ComponentModel.DataAnnotations;

namespace PowerATS.API.DTO
{
    public class CandidatoVagaDto
    {
        public Guid IdCandidatoVaga { get; set; }
        public Guid id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid IdCandidato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid IdVaga { get; set; }
    }
}
