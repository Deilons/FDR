using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Booking.Search
{   
    [ApiController]
    [Authorize]
    [Route("api/v1/booking")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class BookingPOSTController : BookingController
    {
        public BookingPOSTController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<BookingDTO>>> Add(BookingDTO bookingDTO)
        {
            return Ok(await services.Add(bookingDTO));
        }
    }
}