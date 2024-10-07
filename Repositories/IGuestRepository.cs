using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;

namespace FDR.Repositories;

public interface IGuestRepository
{
    Task<IEnumerable<GuestDTO>> GetAll();
    Task<GuestDTO> GetById(int id);
    Task<GuestDTO> GetByKeyword(string keyword);
    Task<GuestDTO> Add(GuestDTO guestDTO);
    Task Delete(int id);
    Task Update(int id, GuestDTO guestDTO);
    Task<bool> CheckExistence(int id);

}

