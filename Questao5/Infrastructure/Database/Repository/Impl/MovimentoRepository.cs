using Questao5.Domain.Entities;

namespace Questao5.Infrastructure.Database.Repository.Impl
{
    public class MovimentoRepository : IMovimentoRepository
    {
        private readonly IBaseRepository _repository;
        public MovimentoRepository(IBaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Movimento>> GetMovimentoByAccount(int account)
        {
            string query = "SELECT m.idmovimento, m.idcontacorrente, m.datamovimento, m.tipomovimento, m.valor " +
                           "FROM movimento m " +
                           "INNER JOIN contacorrente c " +
                           "WHERE c.idcontacorrente = m.idcontacorrente " +
                           "AND m.idcontacorrente  = @idcontacorrente";

            return await _repository.GetDapper<Movimento>(query, new { idcontacorrente = account });
        }
    }
}
