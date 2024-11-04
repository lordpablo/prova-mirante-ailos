using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questao5.Infrastructure.Database.QueryStore.Requests;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCorrenteController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public ContaCorrenteController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet(Name = "GetSaldoContaCorrente")]
        public async Task<IActionResult> Get(ConsultaSaldoRequest request)
        {
            //return await Task.FromResult(_mediator.Send(request));
            return Ok();
        }

    }
}