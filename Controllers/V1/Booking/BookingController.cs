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
    public class BookingController : ControllerBase
    {   
        protected readonly IBookingRepository services;
        public BookingController(IBookingRepository bookingRepository)
        {
            services = bookingRepository;
        }
    }
}