using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;

namespace FDR.Repositories;

public interface IBookingRepository
{
    Task<IEnumerable<BookingDTO>> GetAll();
    Task<BookingDTO> GetById (int id);
    Task<BookingDTO> GetByIdentificationNumber (string identificationNumber);
    Task Delete(int id);

    Task<BookingDTO> Add(BookingDTO bookingDTO);

    Task Update(int id, BookingDTO bookingDTO);

    Task<bool> CheckExistence(int id);

}
