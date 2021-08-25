using CompanyTree.V1.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyTree.Domain.Services.Interfaces
{
    public interface ITeamsService
    {
        Task<TeamContract> CreateTeamAsync(TeamContract teamContract);
        Task<int> DeleteTeamAsync(int id);
        Task<IEnumerable<TeamContract>> GetAllTeamsAsync();
        Task<TeamContract> GetTeamByIdAsync(int id);
        Task<int> UpdateTeamAsync(TeamContract teamContract);
    }
}
