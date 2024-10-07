using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.Models;

[Table("Bookings")]
public class Booking
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Room")]
    public int RoomId { get; set; }

    [ForeignKey("Guest")]
    public int GuestId { get; set; }

    [ForeignKey("Employee")]
    public int EmployeeId { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime StartDate { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime EndDate { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public double TotalCost { get; set; }

    public Room Room { get; set; }
    public Guest Guest { get; set; }
    public Employee Employee { get; set; }
}

