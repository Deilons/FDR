using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.DTOs;

public class RoomDTO
{

    public int Id { get; set; }
    public string RoomName { get; set; }
    public int RoomTypeId { get; set; }
    public double PricePerNight { get; set; }
    public bool Availability { get; set; }
    public int MaxOccupancyPersons { get; set; }
}
