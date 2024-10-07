using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Booking
{   
    [ApiController]
    [Route("api/v1/booking")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class BookingPUTControllers : BookingController
    {
        public BookingPUTControllers(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, BookingDTO bookingDTO)
        {
            await services.Update(id, bookingDTO);
            return NoContent();
        }
    }
}