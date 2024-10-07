using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.DTOs;

public class EmployeeDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
        public string LastName { get; set; }
    public string Email { get; set; }
    public string IdentificationNumber { get; set; }
    public string Password { get; set; }
}
