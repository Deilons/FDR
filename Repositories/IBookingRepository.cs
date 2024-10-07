using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;

namespace FDR.Repositories;

public interface IBookingRepository
{
/*
GET identificaiton  🔒
GET Id 🔒

Delete Id 🔒
*/
    Task<IEnumerable<BookingDTO>> GetAll();
    Task<BookingDTO> GetById (int id);
    Task Delete(int id);
}
