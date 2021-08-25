using CompanyTree.Entities;
using CompanyTree.V1.Contracts;
using System.Collections.Generic;

namespace CompanyTree.Domain.Mappers
{
    public static partial class ModelMapper
    {
        public static RoleContract ToRoleContract(this Role role)
        {
            return new RoleContract
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description,
                Image = role.Image,
                DateCreated = role.DateCreated,
                DateUpdated = role.DateUpdated,
                Employees = new List<EmployeeContract>()
            };
        }

        public static Role ToRoleEntity(this RoleContract roleContract)
        {
            return new Role
            {
                Id = roleContract.Id,
                Name = roleContract.Name,
                Description = roleContract.Description,
                Image = roleContract.Image,
                DateCreated = roleContract.DateCreated,
                DateUpdated = roleContract.DateUpdated,
                Employees = new List<Employee>()
            };
        }
    }
}
