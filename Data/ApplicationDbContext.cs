using Microsoft.EntityFrameworkCore;
using QuickLogistics.Models;

namespace QuickLogistics.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(option) { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Vehicles
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { VehicleId = 1, LicensePlate = "ABC123", Model = "Truck" },
                new Vehicle { VehicleId = 2, LicensePlate = "XYZ789", Model = "Van" },
                new Vehicle { VehicleId = 3, LicensePlate = "DES439", Model = "Bajaj" }
            );

           modelBuilder.Entity<Driver>().HasData(
               new Driver { DriverId = 1, Name = "Adefemi Adedayo", LicenseNumber = "D12345", PhoneNumber = "09043289743", Address= "Iyanapaja, Lagos" },
               new Driver { DriverId = 2, Name = "Azeez Babalola", LicenseNumber = "D67890", PhoneNumber = "08103289243", Address = "Yaba, Lagos" },
               new Driver { DriverId = 3, Name = "Uche Phillips", LicenseNumber = "B47630", PhoneNumber = "08071289463", Address = "Oniru, Lagos" }
           );
            modelBuilder.Entity<Shipment>().HasData(
          new Shipment
          {
              ShipmentId = 1,
              TrackingNumber = "SHIP001",
              ShippedDate = DateTime.Now.AddDays(-5),
              DeliveredDate = DateTime.Now.AddDays(-1),
              VehicleId = 1,
              DriverId = 1
          },
          new Shipment
          {
              ShipmentId = 2,
              TrackingNumber = "SHIP002",
              ShippedDate = DateTime.Now.AddDays(-7),
              DeliveredDate = DateTime.Now.AddDays(-2),
              VehicleId = 2,
              DriverId = 2
          }
      );

        }
    }
}
