using System.ComponentModel.DataAnnotations;

namespace PowerATS.API.DTO
{
    public class CandidatoDto 
    {
        public int id { get; set; }
        public int idCandidato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string NomeCompleto { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int Idade { get; set; }
    }
}
