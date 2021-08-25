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
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly IDbSettings _dbSettings;

        public EmployeesRepository(IDbSettings dbSettings)
        {
            _dbSettings = dbSettings;
        }

        public async Task<Employee> CreateAsync(Employee entity)
        {
            var timeNow = DateTime.UtcNow;

            var sql = "INSERT INTO [dbo].[Employees]([FirstName], [MiddleName], [LastName], [Nationality], [Image], [Phone], [Email], [DateBirth], [DateHired], [DateCreated], [DateUpdated], [IsBoardMember], [RoleId], [TeamId])" +
                        $"VALUES ('{entity.FirstName}', '{entity.MiddleName}', '{entity.LastName}', '{entity.Nationality}', '{entity.Image}', '{entity.Phone}', '{entity.Email}', '{entity.DateBirth}', '{entity.DateHired}', '{timeNow}', '{timeNow}', '{entity.IsBoardMember}', '{entity.RoleId}', '{entity.TeamId}')";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return await GetSingleOrDefaultByEmailAsync(entity.Email);
            }
        }

        public async Task<int> DeleteAsync(int primaryKey)
        {
            var sql = $"DELETE FROM [dbo].[Employees] WHERE [Id] = {primaryKey}";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return result;
            }
        }

        public async Task<IList<Employee>> GetAllAsync()
        {
            var sql = "SELECT * FROM [dbo].[Employees]";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.QueryAsync<Employee>(sql);
                return result.ToList();
            }
        }

        public async Task<Employee> GetSingleOrDefaultAsync(int primaryKey)
        {
            var sql = $"SELECT * FROM [dbo].[Employees] WHERE [Id] = {primaryKey}";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.QueryAsync<Employee>(sql);
                return result.SingleOrDefault();
            }
        }

        public async Task<Employee> GetSingleOrDefaultByEmailAsync(string email)
        {
            var sql = $"SELECT * FROM [dbo].[Employees] WHERE [Email] = '{email}'";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.QueryAsync<Employee>(sql);
                return result.SingleOrDefault();
            }
        }

        public async Task<int> UpdateAsync(Employee entity)
        {
            var timeNow = DateTime.UtcNow;

            var sql = "UPDATE [dbo].[Employees]" +
                      $"SET [FirstName] = '{entity.FirstName}', [MiddleName] = '{entity.MiddleName}', [LastName] = '{entity.LastName}', [Nationality] = '{entity.Nationality}', [Image] = '{entity.Image}', [Phone] = '{entity.Phone}', [Email] = '{entity.Email}', [DateBirth] = '{entity.DateBirth}', [DateHired] = '{entity.DateHired}', [DateCreated] = '{entity.DateCreated}', [DateUpdated] = '{timeNow}', [IsBoardMember] = '{entity.IsBoardMember}', [RoleId] = '{entity.RoleId}', [TeamId] = '{entity.TeamId}'" +
                      $"WHERE [Id] = '{entity.Id}'";

            using (var connection = new SqlConnection(_dbSettings.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql);
                return result;
            }
        }
    }
}
