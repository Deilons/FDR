using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Repositories;
using FiltroDotnet.Config;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace FDR.Controllers.V1.Auth
{
    [ApiController]
    [Route("api/v1/auth")]
    [Tags("auth")]
    public class LoginController : AuthController
    {
        public LoginController(IEmployeeRepository employeeRepository, Utilities utilities) : base(employeeRepository, utilities)
        {
        }
        [HttpPost]
        [Route("login")]
        [SwaggerOperation(
    Summary = "Login Employee",
    Description = "Login Employee with email and password"
)]
        [SwaggerResponse(200, "Employee logged in successfully")]
        [SwaggerResponse(400, "Bad request")]
        [SwaggerResponse(401, "Unauthorized")]
        public async Task<IActionResult> Login(LoginDTO employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var token = await services.Login(employee);

            if (token == null)
            {
                return Unauthorized("You don't have permissions");
            }

            else { return Ok($"Here's the token: {token}"); }
        }
    }

}