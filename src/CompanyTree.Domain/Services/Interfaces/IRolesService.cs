using CompanyTree.V1.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyTree.Domain.Services.Interfaces
{
    public interface IRolesService
    {
        Task<RoleContract> CreateRoleAsync(RoleContract roleContract);
        Task<int> DeleteRoleAsync(int id);
        Task<IEnumerable<RoleContract>> GetAllRolesAsync();
        Task<RoleContract> GetRoleByIdAsync(int id);
        Task<int> UpdateRoleAsync(RoleContract roleContract);
    }
}
