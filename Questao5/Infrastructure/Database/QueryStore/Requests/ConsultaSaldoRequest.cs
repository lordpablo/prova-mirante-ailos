using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Questao5.Infrastructure.Database.QueryStore.Requests
{
    public class ConsultaSaldoRequest : IRequest<IActionResult>
    {
        public int? NumeroConta { get; set; }
    }
}
