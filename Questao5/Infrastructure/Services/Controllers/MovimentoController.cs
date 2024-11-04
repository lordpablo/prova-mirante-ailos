using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questao5.Infrastructure.Database.QueryStore.Requests;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovimentoController : ControllerBase
    {

        private readonly ILogger<MovimentoController> _logger;
        private readonly IMediator _mediator;

        public MovimentoController(ILogger<MovimentoController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost(Name = "PostMovimentoCC")]
        public async Task<IActionResult> Get(ConsultaSaldoRequest request)
        {
            //return await Task.FromResult(_mediator.Send(request));
            return Ok();
        }

    }
}