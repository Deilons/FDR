using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;

namespace FDR.Repositories;

public interface IRoomRepository
{
    Task<IEnumerable<RoomDTO>> GetAll();
    Task<RoomDTO> GetById(int id);
    Task<IEnumerable<RoomDTO>> GetAvailable();
    Task<IEnumerable<RoomDTO>> GetOccupied();
    Task<IEnumerable<RoomDTO>> GetStatus();
    Task<bool> CheckExistence(int id);

}
