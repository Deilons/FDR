using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Controllers.V1.Booking.Search
{
    [ApiController]
    [Route("api/v1/booking")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Booking")]
    public class BookingGETController : BookingController
    {
        public BookingGETController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingDTO>>> GetAll()
        {
            return Ok(await services.GetAll());
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<BookingDTO>>> GetByIdentificationNumber([FromQuery] string identificationNumber)
        {
            return Ok(await services.GetByIdentificationNumber(identificationNumber));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookingDTO>> Get(int id)
        {
            return Ok(await services.GetById(id));
        }

    }
}