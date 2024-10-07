using FDR.Models;
using Microsoft.EntityFrameworkCore;

namespace FDR.Seeders
{
    public static class RoomSeeders
    {
        public static void SeedRooms(ModelBuilder modelBuilder)
        {
            const int totalFloors = 5;
            const int roomsPerFloor = 10;

            int roomNumber = 1;

            for (int floor = 1; floor <= totalFloors; floor++)
            {
                for (int roomIndex = 1; roomIndex <= roomsPerFloor; roomIndex++)
                {
                    int roomTypeId = (roomNumber - 1) % 4 + 1; 

                    modelBuilder.Entity<Room>().HasData(new Room
                    {
                        Id = roomNumber,
                        RoomNumber = $"F{floor}R{roomIndex}", 
                        RoomTypeId = roomTypeId,
                        PricePerNight = roomTypeId switch
                        {
                            1 => 50,
                            2 => 80,
                            3 => 150,
                            4 => 200,
                            _ => throw new ArgumentOutOfRangeException()
                        },
                        Available = true,
                        MaxOccupancyPersons = roomTypeId switch
                        {
                            1 => 1,
                            2 => 2,
                            3 => 2,
                            4 => 4,
                            _ => throw new ArgumentOutOfRangeException()
                        }
                    });

                    roomNumber++;
                }
            }
        }
    }
}