using CompanyTree.Entities;
using CompanyTree.V1.Contracts;
using System.Collections.Generic;

namespace CompanyTree.Domain.Mappers
{
    public static partial class ModelMapper
    {
        public static TeamContract ToTeamContract(this Team team)
        {
            return new TeamContract
            {
                Id = team.Id,
                Name = team.Name,
                Description = team.Description,
                Image = team.Image,
                DateEstablished = team.DateEstablished,
                DateCreated = team.DateCreated,
                DateUpdated = team.DateUpdated,
                Employees = new List<EmployeeContract>()
            };
        }

        public static Team ToTeamEntity(this TeamContract teamContract)
        {
            return new Team
            {
                Id = teamContract.Id,
                Name = teamContract.Name,
                Description = teamContract.Description,
                Image = teamContract.Image,
                DateEstablished = teamContract.DateEstablished,
                DateCreated = teamContract.DateCreated,
                DateUpdated = teamContract.DateUpdated,
                Employees = new List<Employee>()
            };
        }
    }
}
