using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuickLogistics.Migrations
{
    /// <inheritdoc />
    public partial class SeedAndModelCollectionFromVehicleAndDriverToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "ShipmentId", "DeliveredDate", "DriverId", "ShippedDate", "TrackingNumber", "VehicleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 21, 5, 21, 46, 933, DateTimeKind.Local).AddTicks(5479), 1, new DateTime(2024, 8, 17, 5, 21, 46, 933, DateTimeKind.Local).AddTicks(5394), "SHIP001", 1 },
                    { 2, new DateTime(2024, 8, 20, 5, 21, 46, 933, DateTimeKind.Local).AddTicks(5498), 2, new DateTime(2024, 8, 15, 5, 21, 46, 933, DateTimeKind.Local).AddTicks(5494), "SHIP002", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "ShipmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "ShipmentId",
                keyValue: 2);
        }
    }
}
