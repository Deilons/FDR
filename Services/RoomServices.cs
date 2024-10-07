using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Data;
using FDR.DTOs;
using FDR.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FDR.Services;

public class RoomServices : IRoomRepository
{
    private readonly ApplicationDbContext _context;

    public RoomServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Rooms.AnyAsync(x => x.Id == id);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException("Error occurred while checking if the room exists", e);
        }
        catch (Exception ex)
        {
            throw new Exception("Error occurred while checking if the room exists", ex);
        }
    }

    public async Task<IEnumerable<RoomDTO>> GetAll()
    {
        return await _context.Rooms
            .Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomTypeId = r.RoomTypeId,
                RoomType = new RoomTypeDTO
                {
                    Id = r.RoomType.Id,
                    Name = r.RoomType.Name,
                    Description = r.RoomType.Description
                },
                RoomNumber = r.RoomNumber,
                Available = r.Available,
                MaxOccupancyPersons = r.MaxOccupancyPersons
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<RoomDTO>> GetAvailable()
    {
        return await _context.Rooms
            .Where(r => r.Available)
            .Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomTypeId = r.RoomTypeId,
                RoomType = new RoomTypeDTO
                {
                    Id = r.RoomType.Id,
                    Name = r.RoomType.Name,
                    Description = r.RoomType.Description
                },
                RoomNumber = r.RoomNumber,
                Available = r.Available,
                MaxOccupancyPersons = r.MaxOccupancyPersons
            })
            .ToListAsync();
    }

    public async Task<RoomDTO> GetById(int id)
    {
        return await _context.Rooms
            .Where(r => r.Id == id)
            .Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomTypeId = r.RoomTypeId,
                RoomType = new RoomTypeDTO
                {
                    Id = r.RoomType.Id,
                    Name = r.RoomType.Name,
                    Description = r.RoomType.Description
                },
                RoomNumber = r.RoomNumber,
                Available = r.Available,
                MaxOccupancyPersons = r.MaxOccupancyPersons
            })
            .FirstOrDefaultAsync();

    }

    public async Task<IEnumerable<RoomDTO>> GetOccupied()
    {
        return await _context.Rooms
            .Where(r => !r.Available)
            .Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomTypeId = r.RoomTypeId,
                RoomType = new RoomTypeDTO
                {
                    Id = r.RoomType.Id,
                    Name = r.RoomType.Name,
                    Description = r.RoomType.Description
                },
                RoomNumber = r.RoomNumber,
                Available = r.Available,
                MaxOccupancyPersons = r.MaxOccupancyPersons
            })
            .ToListAsync();
    }
    public async Task<IEnumerable<RoomDTO>> GetStatus()
    {
        return await _context.Rooms
            .Select(r => new RoomDTO
            {
                Id = r.Id,
                RoomTypeId = r.RoomTypeId,
                RoomType = new RoomTypeDTO
                {
                    Id = r.RoomType.Id,
                    Name = r.RoomType.Name,
                    Description = r.RoomType.Description
                },
                RoomNumber = r.RoomNumber,
                Available = r.Available,
                MaxOccupancyPersons = r.MaxOccupancyPersons
            })
            .ToListAsync();
    }
}
