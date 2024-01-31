using System.ComponentModel.DataAnnotations;

namespace PowerATS.API.DTO
{
    public class CurriculoDto 
    {
        public int id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int idCurriculo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int idCandidato { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string CurriculoDocumento { get; set; } = null!;
    }
}
