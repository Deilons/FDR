using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Data;
using FDR.Models;
using FDR.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FDR.Services;

public class EmployeeServices : IEmployeeRepository
{
    private readonly ApplicationDbContext _context;

    public EmployeeServices(ApplicationDbContext context)
    {
        _context = context;
    }


    public async Task<Employee> GetByEmail(string Email)
    {
        return await _context.Employees.FirstOrDefaultAsync(u => u.Email == Email);
    }

    public async Task<Employee> GetById(int id)
    {
        return await _context.Employees.FindAsync(id);
    }
}
