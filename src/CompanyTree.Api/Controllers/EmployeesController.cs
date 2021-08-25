using CompanyTree.Domain.Services.Interfaces;
using CompanyTree.V1.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyTree.Api.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] EmployeeContract employee)
        {
            EmployeeContract employeeCreated = await _employeesService.CreateEmployeeAsync(employee);
            return Ok(employeeCreated);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            int result = await _employeesService.DeleteEmployeeAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            IEnumerable<EmployeeContract> employees = await _employeesService.GetAllEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            EmployeeContract employee = await _employeesService.GetEmployeeByIdAsync(id);
            return Ok(employee);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateAsync([FromBody] EmployeeContract employee)
        {
            int result = await _employeesService.UpdateEmployeeAsync(employee);
            return Ok(result);
        }
    }
}
