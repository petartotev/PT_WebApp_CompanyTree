using CompanyTree.Common.Configuration.Interfaces;
using CompanyTree.Entities;
using CompanyTree.Repository.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyTree.Repository
{
    public class TeamsRepository : ITeamsRepository
    {
        private readonly IDbSettings _dbSettings;

        public TeamsRepository(IDbSettings dbSettings)
        {
            _dbSettings = dbSettings;
        }

        public async Task<Team> CreateAsync(Team entity)
        {
            var timeNow = DateTime.UtcNow;

            var sql = "INSERT INTO [dbo].[Teams]([Name], [Description], [Image], [DateEstablished], [DateCreated], [DateUpdated])" +
                        $"VALUES ('{entity.Name}', '{entity.Description}', '{entity.Image}', '{entity.DateEstablished}', '{timeNow}', '{timeNow}')";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return await GetSingleOrDefaultByNameAsync(entity.Name);
            }
        }

        public async Task<int> DeleteAsync(int primaryKey)
        {
            var sql = $"DELETE FROM [dbo].[Teams] WHERE [Id] = {primaryKey}";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return result;
            }
        }

        public async Task<IList<Team>> GetAllAsync()
        {
            var sql = "SELECT * FROM [dbo].[Teams]";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.QueryAsync<Team>(sql);
                return result.ToList();
            }
        }

        public async Task<Team> GetSingleOrDefaultAsync(int primaryKey)
        {
            var sql = $"SELECT * FROM [dbo].[Teams] WHERE [Id] = {primaryKey}";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.QueryAsync<Team>(sql);
                return result.SingleOrDefault();
            }
        }

        public async Task<Team> GetSingleOrDefaultByNameAsync(string name)
        {
            var sql = $"SELECT * FROM [dbo].[Teams] WHERE [Name] = '{name}'";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.QueryAsync<Team>(sql);
                return result.SingleOrDefault();
            }
        }

        public async Task<int> UpdateAsync(Team entity)
        {
            var timeNow = DateTime.UtcNow;

            var sql = "UPDATE [dbo].[Teams]" +
                      $"SET [Name] = '{entity.Name}', [Description] = '{entity.Description}', [Image] = '{entity.Image}', [DateEstablished] = '{entity.DateEstablished}', [DateCreated] = '{entity.DateCreated}', [DateUpdated] = '{timeNow}'" +
                      $"WHERE [Id] = '{entity.Id}'";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return result;
            }
        }
    }
}
