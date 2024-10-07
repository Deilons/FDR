using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Repositories;
using FDR.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Guest
{
    [ApiController]
    [Route("api/v1/guest")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Guest")]
    public class GuestDELETEControllers : GuestController
    {
        public GuestDELETEControllers(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await services.Delete(id);
            return NoContent();
        }
    }
}