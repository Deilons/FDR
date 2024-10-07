using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.Models;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Repositories;

public interface IEmployeeRepository
{
    Task<Employee> GetById(int id);
    Task<Employee> GetByEmail(string mail);

}
