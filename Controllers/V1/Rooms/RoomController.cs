using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Rooms
{    
    [ApiController]
    [Route("api/v1/rooms")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Rooms")]
    public class RoomController : ControllerBase
    {
        protected readonly IRoomRepository services;
        public RoomController(IRoomRepository RoomRepository)
        {
            services = RoomRepository;
        }
    }
}