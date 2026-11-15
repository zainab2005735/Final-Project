
using Microsoft.EntityFrameworkCore;
using DormitoryManagementSystem.Models;

namespace DormitoryManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Resident> Residents { get; set; } = null!;

        public DbSet<Room> Rooms { get; set; } = null!;

        public DbSet<Allocation> Allocations { get; set; } = null!;

        public DbSet<Payment> Payments { get; set; } = null!;

        public DbSet<MaintenanceRequest> MaintenanceRequests { get; set; } = null!;
    }
}
