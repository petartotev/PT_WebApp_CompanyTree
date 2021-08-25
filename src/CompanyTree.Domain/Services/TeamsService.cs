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
    public class TeamsService : ITeamsService
    {
        private readonly IDbContext _dbContext;

        public TeamsService(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TeamContract> CreateTeamAsync(TeamContract teamContract)
        {
            Team teamEntity = teamContract.ToTeamEntity();
            Team teamResult = await _dbContext.TeamsRepo.CreateAsync(teamEntity);
            return teamResult.ToTeamContract();
        }

        public async Task<int> DeleteTeamAsync(int id)
        {
            int result = await _dbContext.TeamsRepo.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<TeamContract>> GetAllTeamsAsync()
        {
            IEnumerable<Team> teamResult = await _dbContext.TeamsRepo.GetAllAsync();
            return teamResult.Select(t => t.ToTeamContract());
        }

        public async Task<TeamContract> GetTeamByIdAsync(int id)
        {
            Team teamEntity = await _dbContext.TeamsRepo.GetSingleOrDefaultAsync(id);
            return teamEntity.ToTeamContract();
        }

        public async Task<int> UpdateTeamAsync(TeamContract teamContract)
        {
            Team teamEntity = teamContract.ToTeamEntity();
            int result = await _dbContext.TeamsRepo.UpdateAsync(teamEntity);
            return result;
        }
    }
}
