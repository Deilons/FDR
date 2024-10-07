using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.DTOs;

public class GuestDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string IdentificationNumber { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
}
