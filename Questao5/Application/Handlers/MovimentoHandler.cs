using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questao5.Infrastructure.Database.CommandStore.Requests;
using Questao5.Mediator;

namespace Questao5.Application.Handlers
{
    public class MovimentoHandler : IRequestHandler<MovimentoRequest, IActionResult>
    {
        public MovimentoHandler(IMapper mapper, IConfiguration configuration, ILogger<MediatorExtension> logger)
        {

        }

        public async Task<IActionResult> Handle(MovimentoRequest request, CancellationToken cancellationToken)
        {
            //fazer regra de negócio.
            return new BadRequestResult();
        }
    }
}
