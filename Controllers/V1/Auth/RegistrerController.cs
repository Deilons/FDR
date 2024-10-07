using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Repositories;
using FDR.Config;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace FDR.Controllers.V1.Auth
{
    [ApiController]
    [Route("api/v1/auth")]
    [Tags("auth")]
    public class RegistrerController : AuthController
    {
        public RegistrerController(IEmployeeRepository employeeRepository, Utilities utilities) : base(employeeRepository, utilities)
        {
        }
        [HttpPost]
        [Route("register")]
        [SwaggerOperation(
    Summary = "Register employee",
    Description = "Register employee in database"
)]
        [SwaggerResponse(201, "Created: Employeed registered successfully")]
        [SwaggerResponse(400, "Bad request")]

        public async Task<IActionResult> Post(EmployeeDTO newEmployee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await services.Register(newEmployee);
            return Created();
        }
    }

}