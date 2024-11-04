using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.Repository.Impl
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {
        private readonly IBaseRepository _repository;
        public ContaCorrenteRepository(IBaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ContaCorrente>> GetAccountById(int account)
        {
            string query = "SELECT idcontacorrente, numero, nome, ativo FROM contacorrente wherer idcontacorrente = @idcontacorrente";

            return await _repository.GetDapper<ContaCorrente>(query, new { idcontacorrente = account });
        }
    }
}
