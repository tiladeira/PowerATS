using System.ComponentModel.DataAnnotations;

namespace PowerATS.API.DTO
{
    public class CandidatoVagaDto
    {
        public int idCandidatoVaga { get; set; }
        public int id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int idCandidato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int idVaga { get; set; }
    }
}
