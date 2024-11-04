using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questao5.Infrastructure.Database.QueryStore.Requests;
using Questao5.Mediator;

namespace Questao5.Application.Handlers
{
    public class ConsultaSaldoHandler : IRequestHandler<ConsultaSaldoRequest, IActionResult>
    {
        public ConsultaSaldoHandler(IMapper mapper, IConfiguration configuration, ILogger<MediatorExtension> logger)
        {

        }

        public async Task<IActionResult> Handle(ConsultaSaldoRequest request, CancellationToken cancellationToken)
        {
            //fazer regra de negócio.
            return new BadRequestResult();
        }
    }
}
