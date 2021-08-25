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
    public class RolesService : IRolesService
    {
        private readonly IDbContext _dbContext;

        public RolesService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<RoleContract> CreateRoleAsync(RoleContract roleContract)
        {
            Role roleEntity = roleContract.ToRoleEntity();
            Role roleResult = await _dbContext.RolesRepo.CreateAsync(roleEntity);
            return roleResult.ToRoleContract();
        }

        public async Task<int> DeleteRoleAsync(int id)
        {
            int result = await _dbContext.RolesRepo.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<RoleContract>> GetAllRolesAsync()
        {
            IEnumerable<Role> roleEntities = await _dbContext.RolesRepo.GetAllAsync();
            return roleEntities.Select(r => r.ToRoleContract());
        }

        public async Task<RoleContract> GetRoleByIdAsync(int id)
        {
            Role roleEntity = await _dbContext.RolesRepo.GetSingleOrDefaultAsync(id);
            return roleEntity.ToRoleContract();
        }

        public async Task<int> UpdateRoleAsync(RoleContract roleContract)
        {
            Role roleEntity = roleContract.ToRoleEntity();
            int result = await _dbContext.RolesRepo.UpdateAsync(roleEntity);
            return result;
        }
    }
}
