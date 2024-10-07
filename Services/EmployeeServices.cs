using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Data;
using FDR.DTOs;
using FDR.Models;
using FDR.Repositories;
using FDR.Config;
using Microsoft.EntityFrameworkCore;

namespace FDR.Services;

public class EmployeeService : IEmployeeRepository
{
    protected readonly ApplicationDbContext _context;
    protected readonly Utilities _utilities;

    public EmployeeService(ApplicationDbContext context, Utilities utilities)
    {
        _context = context;
        _utilities = utilities;
    }

    public async Task Register(EmployeeDTO user)
        {
            user.Password = _utilities.EncryptSHA256(user.Password);
            var user1 = new Employee
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                IdentificationNumber = user.IdentificationNumber,
                Password = user.Password, 
            };
            _context.Employees.Add(user1);
            await _context.SaveChangesAsync();
        }

        public async Task<string> Login(LoginDTO login)
        {
            var user1 = await _context.Employees.FirstOrDefaultAsync(u => u.Email == login.Email);

            if (user1 != null)
            {
                if (user1.Password == _utilities.EncryptSHA256(login.Password))
                {
                    var token = _utilities.GenerateJwtToken(user1);
                    return token;
                }
            }

            return "User or password invalid";
        }

    public async Task<IEnumerable<Employee>> GetAll()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employee> GetById(int id)
    {
        return await _context.Employees
            .FirstOrDefaultAsync(employee => employee.Id == id);
    }
}

