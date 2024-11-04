using System.ComponentModel.DataAnnotations;

namespace Questao5.Domain.Entities
{
    public class ContaCorrente
    {
        [Key]
        [Required]
        public string IdContaCorrente { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public bool Ativo { get; set; } = false;
    }
}
