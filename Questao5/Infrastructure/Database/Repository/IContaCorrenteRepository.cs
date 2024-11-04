using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.Repository
{
    public interface IContaCorrenteRepository
    {
        Task<IEnumerable<ContaCorrente>> GetAccountById(int account);
    }
}
