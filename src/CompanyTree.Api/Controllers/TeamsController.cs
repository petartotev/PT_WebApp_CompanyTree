using CompanyTree.Domain.Services.Interfaces;
using CompanyTree.V1.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyTree.Api.Controllers
{
    [ApiController]
    [Route("teams")]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamsService _teamsService;

        public TeamsController(ITeamsService teamsService)
        {
            _teamsService = teamsService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] TeamContract team)
        {
            TeamContract teamCreated = await _teamsService.CreateTeamAsync(team);
            return Ok(teamCreated);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            int result = await _teamsService.DeleteTeamAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            IEnumerable<TeamContract> teams = await _teamsService.GetAllTeamsAsync();
            return Ok(teams);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            TeamContract team = await _teamsService.GetTeamByIdAsync(id);
            return Ok(team);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateAsync([FromBody] TeamContract team)
        {
            int result = await _teamsService.UpdateTeamAsync(team);
            return Ok(result);
        }
    }
}
