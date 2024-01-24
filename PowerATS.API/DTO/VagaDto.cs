using PowerATS.Domain.Enums;

using System.ComponentModel.DataAnnotations;

namespace PowerATS.API.DTO
{
    public class VagaDto 
    {
        public Guid id { get; set; }
        public Guid IdVaga { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Titulo { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Descricao { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public decimal Valor { get; set; }
    }
}
