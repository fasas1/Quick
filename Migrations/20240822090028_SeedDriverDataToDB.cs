using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuickLogistics.Migrations
{
    /// <inheritdoc />
    public partial class SeedDriverDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Address", "LicenseNumber", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Iyanapaja, Lagos", "D12345", "Adefemi Adedayo", "09043289743" },
                    { 2, "Yaba, Lagos", "D67890", "Azeez Babalola", "08103289243" },
                    { 3, "Oniru, Lagos", "B47630", "Uche Phillips", "08071289463" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
