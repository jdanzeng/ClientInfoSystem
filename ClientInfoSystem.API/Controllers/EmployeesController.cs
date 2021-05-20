using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.ServicesInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientInfoSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeesController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeServices.GetAllEmployees();
            if (employees.Any())
            {
                return Ok(employees);  
            }
            return NotFound("Not Found");
        }


        [HttpGet]
        [Route("{id:int}", Name = "GetEmp")]
        public async Task<ActionResult> GetEmployeeById(int id)
        {
            var movie = await _employeeServices.GetEmployeeById(id);
            return Ok(movie);
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult> RigsterEmployeeAsync(EmployeeRegisterRequestModel model)
        {
            var createdEmp = await _employeeServices.RigsterEmployee(model);
            return CreatedAtRoute("GetEmp", new { id = createdEmp.Id }, createdEmp);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEmployee(EmployeeRegisterRequestModel requestModel)
        {
            await _employeeServices.DeleteEmployee(requestModel);
            return NoContent();
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateEmployee(EmployeeRegisterRequestModel requestModel)
        {
           await _employeeServices.UpdateEmployee(requestModel);
            return Ok();
            
        }

    }
}
