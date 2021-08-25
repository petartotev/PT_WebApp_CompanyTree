using CompanyTree.Domain.Mappers;
using CompanyTree.Domain.Services.Interfaces;
using CompanyTree.Entities;
using CompanyTree.Repository.Interfaces;
using CompanyTree.V1.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyTree.Domain.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IDbContext _dbContext;

        public EmployeesService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<EmployeeContract> CreateEmployeeAsync(EmployeeContract employeeContract)
        {
            Employee employeeEntity = employeeContract.ToEmployeeEntity();
            Employee employeeResult = await _dbContext.EmployeesRepo.CreateAsync(employeeEntity);
            return employeeResult.ToEmployeeContract();
        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
            int result = await _dbContext.EmployeesRepo.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<EmployeeContract>> GetAllEmployeesAsync()
        {
            IEnumerable<Employee> employeeResult = await _dbContext.EmployeesRepo.GetAllAsync();
            return employeeResult.Select(t => t.ToEmployeeContract());
        }

        public async Task<EmployeeContract> GetEmployeeByIdAsync(int id)
        {
            Employee employeeEntity = await _dbContext.EmployeesRepo.GetSingleOrDefaultAsync(id);
            return employeeEntity.ToEmployeeContract();
        }

        public async Task<int> UpdateEmployeeAsync(EmployeeContract employeeContract)
        {
            Employee employeeEntity = employeeContract.ToEmployeeEntity();
            int result = await _dbContext.EmployeesRepo.UpdateAsync(employeeEntity);
            return result;
        }
    }
}
