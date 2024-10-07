using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Booking
{   
    [ApiController]
    [Route("api/v1/booking")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class BookingDELETEControllers : BookingController
    {
        public BookingDELETEControllers(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpDelete ("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await services.Delete(id);
            return NoContent();
        }
    }
}