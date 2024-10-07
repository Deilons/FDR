using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Repositories;
using FDR.Config;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Auth
{
    [ApiController]
    [Route("api/v1/auth")]
    [Tags("auth")]
    public class AuthGETControllers : AuthController
    {
        public AuthGETControllers(IEmployeeRepository employeeRepository, Utilities utilities) : base(employeeRepository, utilities)
        {
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await services.GetAll());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await services.GetById(id));
        }
    }
}