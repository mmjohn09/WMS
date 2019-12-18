using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseSystem.Data.Migrations
{
    public partial class stuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Supplier");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Supplier",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Supplier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Supplier");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Supplier",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
