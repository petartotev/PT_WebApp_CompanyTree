using CompanyTree.V1.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyTree.Domain.Services.Interfaces
{
    public interface IEmployeesService
    {
        Task<EmployeeContract> CreateEmployeeAsync(EmployeeContract employeeContract);
        Task<int> DeleteEmployeeAsync(int id);
        Task<IEnumerable<EmployeeContract>> GetAllEmployeesAsync();
        Task<EmployeeContract> GetEmployeeByIdAsync(int id);
        Task<int> UpdateEmployeeAsync(EmployeeContract employeeContract);
    }
}
