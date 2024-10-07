using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Guest
{
    [ApiController]
    [Route("api/v1/guest")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Guest")]
    public class GuestPOSTController : GuestController
    {
        public GuestPOSTController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpPost]
        public async Task<ActionResult<GuestDTO>> Post([FromBody] GuestDTO guestDTO)
        {
            return await services.Add(guestDTO);
        }
    }
}