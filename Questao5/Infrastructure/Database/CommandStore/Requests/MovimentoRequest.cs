using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Questao5.Infrastructure.Database.CommandStore.Requests
{
    public class MovimentoRequest : IRequest<IActionResult>
    {
        [Required]
        public string IdContaCorrente { get; set; }
        [Required]
        public string TipoMovimento { get; set; }
        [Required]
        public double Valor { get; set; }
    }
}
