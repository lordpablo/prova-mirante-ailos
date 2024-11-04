using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Questao5.Domain.Entities
{
    public class Movimento
    {
        [Key]
        [Required]
        public string IdMovimento { get; set; }
        [ForeignKey("ContaCorrente")]
        [Required]
        public string IdContaCorrente { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        [Required]
        public DateTime DataMovimento { get; set; }
        [Required]
        public string TipoMovimento { get; set; }
        [Required]
        public double Valor { get; set; }
    }
}
