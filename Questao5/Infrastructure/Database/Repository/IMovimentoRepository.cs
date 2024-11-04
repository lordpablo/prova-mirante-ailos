using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.Repository
{
    public interface IMovimentoRepository
    {
        Task<IEnumerable<Movimento>> GetMovimentoByAccount(int account);
    }
}
