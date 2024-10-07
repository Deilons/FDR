using FDR.Models;
using Microsoft.EntityFrameworkCore;

namespace FDR.Seeders
{
    public class RoomTypeSeeders
    {
        public static void SeedRoomTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Simple", Description = "Una acogedora habitación básica con una cama individual, ideal para viajeros solos." },
                new RoomType { Id = 2, Name = "Doble", Description = "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos." },
                new RoomType { Id = 3, Name = "Suite", Description = "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad." },
                new RoomType { Id = 4, Name = "Familiar", Description = "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda." }
            );
        }
    }
}