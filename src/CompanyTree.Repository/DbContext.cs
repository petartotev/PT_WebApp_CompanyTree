using CompanyTree.Common.Configuration.Interfaces;
using CompanyTree.Repository.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace CompanyTree.Repository
{
    public class DbContext : IDbContext
    {
        private readonly IDbSettings _settings;

        public DbContext(IDbSettings settings,
            IEmployeesRepository employeeRepo,
            IRolesRepository rolesRepo,
            ITeamsRepository teamsRepo)
        {
            _settings = settings;

            EmployeesRepo = employeeRepo;
            RolesRepo = rolesRepo;
            TeamsRepo = teamsRepo;
        }

        public IEmployeesRepository EmployeesRepo { get; }
        public IRolesRepository RolesRepo { get; }
        public ITeamsRepository TeamsRepo { get; }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_settings.ConnectionString);
        }
    }
}
