using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDR.DTOs;
using FDR.Models;
using Microsoft.AspNetCore.Mvc;

namespace FDR.Repositories;

public interface IEmployeeRepository
{
    Task Register(EmployeeDTO employee);
    Task<string> Login(LoginDTO loginInfo);

    Task<IEnumerable<Employee>> GetAll();
    Task<Employee> GetById(int id);
}
