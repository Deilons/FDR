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
    public class GuestPUTControllers : GuestController
    {
        public GuestPUTControllers(IGuestRepository guestRepository) : base(guestRepository)
        {
        }
        [HttpPut ("{id}")]
        public async Task<ActionResult> Update(int id, GuestDTO guestDTO)
        {
            await services.Update(id, guestDTO);
            return NoContent();
        }
    }
        
}