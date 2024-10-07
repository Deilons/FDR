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
    public class LoginController : AuthController
    {
        public LoginController(IEmployeeRepository employeeRepository, Utilities utilities) : base(employeeRepository, utilities)
        {
        }
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<string>> login( LoginDTO login)
        {
            var token = await services.Login(login);
            return Ok($"Logged in successfully this is your token: {token}");
            //login.Password = _utilities.EncryptSHA256(login.Password);
            //return Ok(await services.Login(login));

        }
    }

}