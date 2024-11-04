using Dapper;
using Microsoft.Data.Sqlite;
using Questao5.Infrastructure.Sqlite;

namespace Questao5.Infrastructure.Database
{
    public class BaseRepository : IBaseRepository
    {
        private readonly DatabaseConfig databaseConfig;

        /// <summary>
        /// 
        /// </summary>
        public BaseRepository(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }

        /// <summary>
        /// Execute Dapper Command
        /// </summary>
        public async Task<bool> ExecuteDapper(string command, object param)
        {
            try
            {
                using var connection = new SqliteConnection(databaseConfig.Name);

                await connection.ExecuteAsync(command, param);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<T>> GetDapper<T>(string command, object param)
        {
            try
            {
                using var connection = new SqliteConnection(databaseConfig.Name);

                return await connection.QueryAsync<T>(command, param);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
