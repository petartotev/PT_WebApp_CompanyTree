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
    public class RolesRepository : IRolesRepository
    {
        private readonly IDbSettings _dbSettings;

        public RolesRepository(IDbSettings dbSettings)
        {
            _dbSettings = dbSettings;
        }

        public async Task<Role> CreateAsync(Role entity)
        {
            var timeNow = DateTime.UtcNow;

            var sql = "INSERT INTO [dbo].[Roles]([Name], [Description], [DateCreated], [DateUpdated])" +
                        $"VALUES ('{entity.Name}', '{entity.Description}', '{timeNow}', '{timeNow}')";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return await GetSingleOrDefaultByNameAsync(entity.Name);
            }
        }

        public async Task<int> DeleteAsync(int primaryKey)
        {
            var sql = $"DELETE FROM [dbo].[Roles] WHERE [Id] = {primaryKey}";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return result;
            }
        }

        public async Task<IList<Role>> GetAllAsync()
        {
            var sql = "SELECT * FROM [dbo].[Roles]";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.QueryAsync<Role>(sql);
                return result.ToList();
            }
        }

        public async Task<Role> GetSingleOrDefaultAsync(int primaryKey)
        {
                var sql = $"SELECT * FROM [dbo].[Roles] WHERE [Id] = {primaryKey}";

                using (var connection = new SqlConnection(_dbSettings.ConnectionString))
                {
                    var result = await connection.QueryAsync<Role>(sql);
                    return result.SingleOrDefault();
                }
        }

        public async Task<Role> GetSingleOrDefaultByNameAsync(string name)
        {
            var sql = $"SELECT * FROM [dbo].[Roles] WHERE [Name] = '{name}'";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.QueryAsync<Role>(sql);
                return result.SingleOrDefault();
            }
        }

        public async Task<int> UpdateAsync(Role entity)
        {
            var timeNow = DateTime.UtcNow;

            var sql = "UPDATE [dbo].[Roles]" +
                      $"SET [Name] = '{entity.Name}', [Description] = '{entity.Description}', [DateCreated] = '{entity.DateCreated}', [DateUpdated] = '{timeNow}'" +
                      $"WHERE [Id] = '{entity.Id}'";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return result;
            }
        }
    }
}
