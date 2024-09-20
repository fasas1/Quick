using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickLogistics.Migrations
{
    /// <inheritdoc />
    public partial class AddDriverIdToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Drivers",
                newName: "DriverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DriverId",
                table: "Drivers",
                newName: "Id");
        }
    }
}
