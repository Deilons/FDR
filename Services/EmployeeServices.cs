using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Data;
using FDR.DTOs;
using FDR.Models;
using FDR.Repositories;
using FiltroDotnet.Config;
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

    public async Task Register(EmployeeDTO employee)
    {
        employee.Password = _utilities.EncryptSHA256(employee.Password);

        var newEmployee = new Employee
        {
            FirstName = employee.FirstName.ToLower(),
            LastName = employee.LastName.ToLower(),
            IdentificationNumber = employee.IdentificationNumber.ToLower(),
            Email = employee.Email.ToLower(),
            Password = employee.Password,
        };

        _context.Employees.Add(newEmployee);
        await _context.SaveChangesAsync();
    }

    public async Task<string> Login(LoginDTO loginInfo)
    {
        var employee = await _context.Employees.FirstOrDefaultAsync(employee => employee.Email == loginInfo.Email);

        if (employee == null)
        { 
            return null;
        }

        if (employee.Password == _utilities.EncryptSHA256(loginInfo.Password))
        {
            var token = _utilities.GenerateJwtToken(employee);
            return token;
        }

        return null;
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

