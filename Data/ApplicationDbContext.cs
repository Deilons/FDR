using FDR.Models;
using Microsoft.EntityFrameworkCore;

namespace FDR.Data;


public class ApplicationDbContext : DbContext
{
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>()
            .HasOne(r => r.RoomType)
            .WithMany(rt => rt.Rooms)
            .HasForeignKey(r => r.RoomTypeId);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Room)
            .WithMany(r => r.Bookings)
            .HasForeignKey(b => b.RoomId);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Guest)
            .WithMany(g => g.Bookings)
            .HasForeignKey(b => b.GuestId);

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Employee)
            .WithMany(e => e.Bookings)
            .HasForeignKey(b => b.EmployeeId);
    }
}