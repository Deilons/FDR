using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Data;
using FDR.DTOs;
using FDR.Models;
using FDR.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FDR.Services;

public class GuestServices : IGuestRepository
{
    private readonly ApplicationDbContext _context;

    public GuestServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<GuestDTO> Add(GuestDTO guestDTO)
    {
        var guest = new Guest
        {
            Id = guestDTO.Id,
            FirstName = guestDTO.FirstName,
            LastName = guestDTO.LastName,
            Email = guestDTO.Email,
            IdentificationNumber = guestDTO.IdentificationNumber,
            PhoneNumber = guestDTO.PhoneNumber,
            BirthDate = guestDTO.BirthDate
        };
        await _context.Guests.AddAsync(guest);
        await _context.SaveChangesAsync();
        return new GuestDTO
        {
            Id = guest.Id,
            FirstName = guest.FirstName,
            LastName = guest.LastName,
            Email = guest.Email,
            IdentificationNumber = guest.IdentificationNumber,
            PhoneNumber = guest.PhoneNumber,
            BirthDate = guest.BirthDate
        };
    }

    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Guests.AnyAsync(x => x.Id == id);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException("Error occurred while checking if the guest exists", e);
        }
        catch (Exception ex)
        {
            throw new Exception("Error occurred while checking if the guest exists", ex);
        }
    }

    public async Task Delete(int id)
    {
        var guest = await _context.Guests.FindAsync(id);
        if (guest != null)
        {
            _context.Guests.Remove(guest);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<GuestDTO>> GetAll()
    {
        return await _context.Guests
            .Select(g => new GuestDTO
            {
                Id = g.Id,
                FirstName = g.FirstName,
                LastName = g.LastName,
                Email = g.Email,
                IdentificationNumber = g.IdentificationNumber,
                PhoneNumber = g.PhoneNumber,
                BirthDate = g.BirthDate
            })
            .ToListAsync();
    }

    public async Task<GuestDTO> GetById(int id)
    {
        var guest = await _context.Guests.FindAsync(id);
        if (guest == null)
        {
            return null;
        }
        return new GuestDTO
        {
            Id = guest.Id,
            FirstName = guest.FirstName,
            LastName = guest.LastName,
            Email = guest.Email,
            IdentificationNumber = guest.IdentificationNumber,
            PhoneNumber = guest.PhoneNumber,
            BirthDate = guest.BirthDate
        };
    }

    public async Task<GuestDTO> GetByKeyword(string keyword)
    {    
        var guest = await _context.Guests
            .Where(g => g.FirstName.Contains(keyword) || g.LastName.Contains(keyword))
            .Select(g => new GuestDTO
            {
                Id = g.Id,
                FirstName = g.FirstName,
                LastName = g.LastName,
                Email = g.Email,
                IdentificationNumber = g.IdentificationNumber,
                PhoneNumber = g.PhoneNumber,
                BirthDate = g.BirthDate
            })
            .FirstOrDefaultAsync();
        if (guest == null)
        {
            return null;
        }
        return guest;
    }

    public async Task Update(int id, GuestDTO guestDTO)
    {
        var guest = await _context.Guests.FindAsync(id);
        if (guest != null)
        {
            guest.FirstName = guestDTO.FirstName;
            guest.LastName = guestDTO.LastName;
            guest.Email = guestDTO.Email;
            guest.IdentificationNumber = guestDTO.IdentificationNumber;
            guest.PhoneNumber = guestDTO.PhoneNumber;
            guest.BirthDate = guestDTO.BirthDate;
            await _context.SaveChangesAsync();
        }
    }
}
