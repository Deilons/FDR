using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FDR.Migrations
{
    /// <inheritdoc />
    public partial class Seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Guests",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.", "Simple" },
                    { 2, "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.", "Doble" },
                    { 3, "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.", "Suite" },
                    { 4, "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "Familiar" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Available", "MaxOccupancyPersons", "PricePerNight", "RoomNumber", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, true, 1, 50m, "F1R1", 1 },
                    { 2, true, 2, 80m, "F1R2", 2 },
                    { 3, true, 2, 150m, "F1R3", 3 },
                    { 4, true, 4, 200m, "F1R4", 4 },
                    { 5, true, 1, 50m, "F1R5", 1 },
                    { 6, true, 2, 80m, "F1R6", 2 },
                    { 7, true, 2, 150m, "F1R7", 3 },
                    { 8, true, 4, 200m, "F1R8", 4 },
                    { 9, true, 1, 50m, "F1R9", 1 },
                    { 10, true, 2, 80m, "F1R10", 2 },
                    { 11, true, 2, 150m, "F2R1", 3 },
                    { 12, true, 4, 200m, "F2R2", 4 },
                    { 13, true, 1, 50m, "F2R3", 1 },
                    { 14, true, 2, 80m, "F2R4", 2 },
                    { 15, true, 2, 150m, "F2R5", 3 },
                    { 16, true, 4, 200m, "F2R6", 4 },
                    { 17, true, 1, 50m, "F2R7", 1 },
                    { 18, true, 2, 80m, "F2R8", 2 },
                    { 19, true, 2, 150m, "F2R9", 3 },
                    { 20, true, 4, 200m, "F2R10", 4 },
                    { 21, true, 1, 50m, "F3R1", 1 },
                    { 22, true, 2, 80m, "F3R2", 2 },
                    { 23, true, 2, 150m, "F3R3", 3 },
                    { 24, true, 4, 200m, "F3R4", 4 },
                    { 25, true, 1, 50m, "F3R5", 1 },
                    { 26, true, 2, 80m, "F3R6", 2 },
                    { 27, true, 2, 150m, "F3R7", 3 },
                    { 28, true, 4, 200m, "F3R8", 4 },
                    { 29, true, 1, 50m, "F3R9", 1 },
                    { 30, true, 2, 80m, "F3R10", 2 },
                    { 31, true, 2, 150m, "F4R1", 3 },
                    { 32, true, 4, 200m, "F4R2", 4 },
                    { 33, true, 1, 50m, "F4R3", 1 },
                    { 34, true, 2, 80m, "F4R4", 2 },
                    { 35, true, 2, 150m, "F4R5", 3 },
                    { 36, true, 4, 200m, "F4R6", 4 },
                    { 37, true, 1, 50m, "F4R7", 1 },
                    { 38, true, 2, 80m, "F4R8", 2 },
                    { 39, true, 2, 150m, "F4R9", 3 },
                    { 40, true, 4, 200m, "F4R10", 4 },
                    { 41, true, 1, 50m, "F5R1", 1 },
                    { 42, true, 2, 80m, "F5R2", 2 },
                    { 43, true, 2, 150m, "F5R3", 3 },
                    { 44, true, 4, 200m, "F5R4", 4 },
                    { 45, true, 1, 50m, "F5R5", 1 },
                    { 46, true, 2, 80m, "F5R6", 2 },
                    { 47, true, 2, 150m, "F5R7", 3 },
                    { 48, true, 4, 200m, "F5R8", 4 },
                    { 49, true, 1, 50m, "F5R9", 1 },
                    { 50, true, 2, 80m, "F5R10", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "BirthDate",
                table: "Guests",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }
    }
}
