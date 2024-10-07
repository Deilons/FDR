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

public class BookingServices : IBookingRepository
{
    private readonly ApplicationDbContext _context;

    public BookingServices(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Bookings.AnyAsync(x => x.Id == id);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException("Error occurred while checking if The booking exists", e);
        }
        catch (Exception ex)
        {
            throw new Exception("Error occurred while checking if The booking exists", ex);
        }
    }

    public async Task<BookingDTO> Add(BookingDTO bookingDTO)
    {
        var b = new Booking
        {
            Id = bookingDTO.Id,
            RoomId = bookingDTO.RoomId,
            GuestId = bookingDTO.GuestId,
            EmployeeId = bookingDTO.EmployeeId,
            StartDate = bookingDTO.StartDate,
            EndDate = bookingDTO.EndDate,
            TotalCost = bookingDTO.TotalCost
        };
        await _context.Bookings.AddAsync(b);
        await _context.SaveChangesAsync();
        return new BookingDTO
        {
            Id = b.Id,
            RoomId = b.RoomId,
            GuestId = b.GuestId,
            EmployeeId = b.EmployeeId,
            StartDate = b.StartDate,
            EndDate = b.EndDate,
            TotalCost = b.TotalCost
        };
    }

    public async Task Delete(int id)
    {
        var booking = await _context.Bookings.FindAsync(id);
        if (booking != null)
        {
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<BookingDTO>> GetAll()
    {
        return await _context.Bookings
            .Select(b => new BookingDTO
            {
                Id = b.Id,
                RoomId = b.RoomId,
                Room = new RoomDTO
                {
                    Id = b.Room.Id,
                    RoomTypeId = b.Room.RoomTypeId,
                    RoomType = new RoomTypeDTO
                    {
                        Id = b.Room.RoomType.Id,
                        Name = b.Room.RoomType.Name,
                        Description = b.Room.RoomType.Description
                    },
                    RoomNumber = b.Room.RoomNumber,
                    Available = b.Room.Available,
                    MaxOccupancyPersons = b.Room.MaxOccupancyPersons
                },
                GuestId = b.GuestId,
                Guest = new GuestDTO
                {
                    Id = b.Guest.Id,
                    FirstName = b.Guest.FirstName,
                    LastName = b.Guest.LastName,
                    Email = b.Guest.Email,
                    IdentificationNumber = b.Guest.IdentificationNumber,
                    PhoneNumber = b.Guest.PhoneNumber,
                    BirthDate = b.Guest.BirthDate
                },
                EmployeeId = b.EmployeeId,
                Employee = new EmployeeDTO
                {
                    Id = b.Employee.Id,
                    FirstName = b.Employee.FirstName,
                    LastName = b.Employee.LastName,
                    Email = b.Employee.Email,
                    IdentificationNumber = b.Employee.IdentificationNumber,
                },
                StartDate = b.StartDate,
                EndDate = b.EndDate
            })
            .ToListAsync();
    }

    public async Task<BookingDTO> GetById(int id)
    {
        var booking = await _context.Bookings
            .Where(b => b.Id == id)
            .Select(b => new BookingDTO
            {
                Id = b.Id,
                RoomId = b.RoomId,
                Room = new RoomDTO
                {
                    Id = b.Room.Id,
                    RoomTypeId = b.Room.RoomTypeId,
                    RoomType = new RoomTypeDTO
                    {
                        Id = b.Room.RoomType.Id,
                        Name = b.Room.RoomType.Name,
                        Description = b.Room.RoomType.Description
                    },
                    RoomNumber = b.Room.RoomNumber,
                    Available = b.Room.Available,
                    MaxOccupancyPersons = b.Room.MaxOccupancyPersons
                },
                GuestId = b.GuestId,
                Guest = new GuestDTO
                {
                    Id = b.Guest.Id,
                    FirstName = b.Guest.FirstName,
                    LastName = b.Guest.LastName,
                    Email = b.Guest.Email,
                    IdentificationNumber = b.Guest.IdentificationNumber,
                    PhoneNumber = b.Guest.PhoneNumber,
                    BirthDate = b.Guest.BirthDate
                },
                EmployeeId = b.EmployeeId,
                Employee = new EmployeeDTO
                {
                    Id = b.Employee.Id,
                    FirstName = b.Employee.FirstName,
                    LastName = b.Employee.LastName,
                    Email = b.Employee.Email,
                    IdentificationNumber = b.Employee.IdentificationNumber,
                },
                StartDate = b.StartDate,
                EndDate = b.EndDate
            })
            .FirstOrDefaultAsync();
        if (booking == null)
        {
            return null;
        }
        return booking;
    }

    public async Task<BookingDTO> GetByIdentificationNumber(string identificationNumber)
    {
        var booking = await _context.Bookings
                .Where(b => b.Guest.IdentificationNumber == identificationNumber)
                .Select(b => new BookingDTO
                {
                    Id = b.Id,
                    RoomId = b.RoomId,
                    Room = new RoomDTO
                    {
                        Id = b.Room.Id,
                        RoomTypeId = b.Room.RoomTypeId,
                        RoomType = new RoomTypeDTO
                        {
                            Id = b.Room.RoomType.Id,
                            Name = b.Room.RoomType.Name,
                            Description = b.Room.RoomType.Description
                        },
                        RoomNumber = b.Room.RoomNumber,
                        Available = b.Room.Available,
                        MaxOccupancyPersons = b.Room.MaxOccupancyPersons
                    },
                    GuestId = b.GuestId,
                    Guest = new GuestDTO
                    {
                        Id = b.Guest.Id,
                        FirstName = b.Guest.FirstName,
                        LastName = b.Guest.LastName,
                        Email = b.Guest.Email,
                        IdentificationNumber = b.Guest.IdentificationNumber,
                        PhoneNumber = b.Guest.PhoneNumber,
                        BirthDate = b.Guest.BirthDate
                    },
                    EmployeeId = b.EmployeeId,
                    Employee = new EmployeeDTO
                    {
                        Id = b.Employee.Id,
                        FirstName = b.Employee.FirstName,
                        LastName = b.Employee.LastName,
                        Email = b.Employee.Email,
                        IdentificationNumber = b.Employee.IdentificationNumber,
                    },
                    StartDate = b.StartDate,
                    EndDate = b.EndDate
                })
                    .FirstOrDefaultAsync();
        if (booking == null)
        {
            return null;
        }
        return booking;
    }

    public async Task Update(int id, BookingDTO bookingDTO)
    {
        var b = await _context.Bookings.FindAsync(id);
        if (b != null)
        {
            b.RoomId = bookingDTO.RoomId;
            b.GuestId = bookingDTO.GuestId;
            b.EmployeeId = bookingDTO.EmployeeId;
            b.StartDate = bookingDTO.StartDate;
            b.EndDate = bookingDTO.EndDate;
            await _context.SaveChangesAsync();
        }
    }
}
