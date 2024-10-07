using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Data;
using FDR.Models;
using FDR.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FDR.Services;

public class RoomTypeServices : IRoomTypeRepository
{
    private readonly ApplicationDbContext _context;

    public RoomTypeServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.RoomTypes.AnyAsync(x => x.Id == id);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException("Error occurred while checking if the room type exists", e);
        }
        catch (Exception ex)
        {
            throw new Exception("Error occurred while checking if the room type exists", ex);
        }
    }

    public async Task<IEnumerable<RoomType>> GetAll()
    {
        return await _context.RoomTypes.ToListAsync();
    }

    public async Task<RoomType> GetById(int id)
    {
        return await _context.RoomTypes.FindAsync(id);
    }
}
