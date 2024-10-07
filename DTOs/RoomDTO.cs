using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.DTOs;

public class RoomDTO
{
    public int Id { get; set; }
    public int RoomTypeId { get; set; }
    public RoomTypeDTO RoomType { get; set; }
    public string RoomNumber { get; set; }
    public string Description { get; set; }
    public bool Available { get; set; } 
    public int MaxOccupancyPersons { get; set; }
}
