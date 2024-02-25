using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public virtual DbSet<Customer> Customer { get; set; } = null!;
        public virtual DbSet<Place> Place { get; set; } = null!;
        public virtual DbSet<StatusVehicle> StatusVehicle { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicle { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
