using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStore_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Migrating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "shipment_id",
                table: "Carriers",
                newName: "carrier_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "carrier_id",
                table: "Carriers",
                newName: "shipment_id");
        }
    }
}
