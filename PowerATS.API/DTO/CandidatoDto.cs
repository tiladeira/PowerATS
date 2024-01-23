using System.ComponentModel.DataAnnotations;

namespace PowerATS.API.DTO
{
    public class CandidatoDto 
    {
        public Guid id { get; set; }
        public Guid IdCandidato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string NomeCompleto { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int Idade { get; set; }
    }
}
