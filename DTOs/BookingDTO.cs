using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.DTOs;

public class BookingDTO
{
    public int Id { get; set; }
    public int RoomId { get; set; }
    public int GuestId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double TotalCost { get; set; }

    public RoomDTO Room { get; set; }
    public GuestDTO Guest { get; set; }
    public EmployeeDTO Employee { get; set; }
}
