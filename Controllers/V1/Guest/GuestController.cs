using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Guest
{
    [ApiController]
    [Route("api/v1/guest")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Guest")]
    public class GuestController : ControllerBase
    {
        protected readonly IGuestRepository services;
        public GuestController(IGuestRepository guestRepository)
        {
            services = guestRepository;
        }
    }
}