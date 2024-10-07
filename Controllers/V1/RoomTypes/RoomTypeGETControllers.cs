using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.RoomTypes
{
    [ApiController]
    [Route("api/v1/roomsType")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("RoomsTypes")]
    public class RoomTypeGETControllers : RoomTypeController
    {
        public RoomTypeGETControllers(IRoomTypeRepository RoomTypeRepository) : base(RoomTypeRepository)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<RoomTypeDTO>>> Get()
        {
            return Ok(await services.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoomTypeDTO>> Get(int id)
        {
            return Ok(await services.GetById(id));
        }
    }
}