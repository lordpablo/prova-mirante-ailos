namespace Questao5.Infrastructure.Database
{
    public interface IBaseRepository
    {
        Task<IEnumerable<T>> GetDapper<T>(string command, object param);
        Task<bool> ExecuteDapper(string command, object param);
    }
}
