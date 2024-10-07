using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.RoomTypes
{   
    [ApiController]
    [Route("api/v1/roomsType")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("RoomsTypes")]
    public class RoomTypeController : ControllerBase
    {
        protected readonly IRoomTypeRepository services;
        public RoomTypeController(IRoomTypeRepository RoomTypeRepository)
        {
            services = RoomTypeRepository;
        }
    }
}