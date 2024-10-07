using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Rooms
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomGETControllers : RoomController
    {
        public RoomGETControllers(IRoomRepository RoomRepository) : base(RoomRepository)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRooms()
        {
            return Ok(await services.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            return Ok(await services.GetById(id));
        }

        [HttpGet("occupied")]
        public async Task<IActionResult> GetOccupiedRooms()
        {
            return Ok(await services.GetOccupied());
        }

        [HttpGet("available")]
        public async Task<IActionResult> GetAvailableRooms()
        {
            return Ok(await services.GetAvailable());
        }

        [HttpGet("status")]
        public async Task<IActionResult> GetStatus()
        {
            return Ok(await services.GetStatus());
        }
    }
}