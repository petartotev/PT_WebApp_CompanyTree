using CompanyTree.Domain.Services.Interfaces;
using CompanyTree.V1.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyTree.Api.Controllers
{
    [ApiController]
    [Route("roles")]
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _rolesService;

        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] RoleContract role)
        {
            RoleContract roleCreated = await _rolesService.CreateRoleAsync(role);
            return Ok(roleCreated);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            int result = await _rolesService.DeleteRoleAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            IEnumerable<RoleContract> roles = await _rolesService.GetAllRolesAsync();
            return Ok(roles);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            RoleContract role = await _rolesService.GetRoleByIdAsync(id);
            return Ok(role);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateAsync([FromBody] RoleContract role)
        {
            int result = await _rolesService.UpdateRoleAsync(role);
            return Ok(result);
        }
    }
}
