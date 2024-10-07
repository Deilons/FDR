using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Data;
using FDR.Repositories;

namespace FDR.Services;

public class EmployeeServices : IEmployeeRepository
{
    private readonly ApplicationDbContext _context;

    public EmployeeServices(ApplicationDbContext context)
    {
        _context = context;
    }
}
