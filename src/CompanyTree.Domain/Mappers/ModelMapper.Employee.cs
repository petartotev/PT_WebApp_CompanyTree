using CompanyTree.Entities;
using CompanyTree.V1.Contracts;

namespace CompanyTree.Domain.Mappers
{
    public static partial class ModelMapper
    {
        public static EmployeeContract ToEmployeeContract(this Employee employee)
        {
            return new EmployeeContract
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                Image = employee.Image,
                Phone = employee.Phone,
                Email = employee.Email,
                Nationality = employee.Nationality,
                IsBoardMember = employee.IsBoardMember,
                DateBirth = employee.DateBirth,
                DateHired = employee.DateHired,
                DateCreated = employee.DateCreated,
                DateUpdated = employee.DateUpdated,
                RoleId = employee.RoleId,
                TeamId = employee.TeamId
            };
        }

        public static Employee ToEmployeeEntity(this EmployeeContract employeeContract)
        {
            return new Employee
            {
                Id = employeeContract.Id,
                FirstName = employeeContract.FirstName,
                MiddleName = employeeContract.MiddleName,
                LastName = employeeContract.LastName,
                Image = employeeContract.Image,
                Phone = employeeContract.Phone,
                Email = employeeContract.Email,
                Nationality = employeeContract.Nationality,
                IsBoardMember = employeeContract.IsBoardMember,
                DateBirth = employeeContract.DateBirth,
                DateHired = employeeContract.DateHired,
                DateCreated = employeeContract.DateCreated,
                DateUpdated = employeeContract.DateUpdated,
                RoleId = employeeContract.RoleId,
                TeamId = employeeContract.TeamId
            };
        }
    }
}
