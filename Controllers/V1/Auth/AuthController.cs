using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Models;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;
using FDR.Config;

namespace FDR.Controllers.V1.Auth
{

    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        protected readonly IEmployeeRepository services;
        protected readonly Utilities _utilities;
        public AuthController(IEmployeeRepository employeeRepository, Utilities utilities)
        {
            services = employeeRepository;
            _utilities = utilities;

        }
    }

}

