using AutoMapper;

namespace Questao5.Mediator
{
    public class MediatorExtension
    {
        protected readonly IConfiguration _config;
        protected readonly IMapper _mapper;
        protected readonly ILogger<MediatorExtension> _logger;

        public MediatorExtension(IMapper mapper, IConfiguration configuration, ILogger<MediatorExtension> logger)
        {
            _config = configuration;
            _mapper = mapper;
            _logger = logger;
        }

        protected async Task<IResponse> ExecHandle<IResponse>(Func<Task<IResponse>> func)
        {
            try
            {
                return await func.Invoke();
            }
            catch (Exception ex)
            {
                _logger.LogError(message: ex.Message ?? "Erro");

                throw;
            }
        }
    }
}
