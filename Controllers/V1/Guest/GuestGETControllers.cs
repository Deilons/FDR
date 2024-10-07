using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Guest.Search
{
    [ApiController]
    [Route("api/v1/guest")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Guest")]
    public class GuestGETControllers : GuestController
    {
        public GuestGETControllers(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<GuestDTO>>> GetAll()
        {
            return Ok(await services.GetAll());
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<GuestDTO>> Get(int id)
        {
            return Ok(await services.GetById(id));
        }

        [HttpGet("search")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<GuestDTO>>> GetByKeyword([FromQuery] string keyword)
        {
            return Ok(await services.GetByKeyword(keyword));
        }
    }
}