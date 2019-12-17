using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseSystem.Data.Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LeadTime",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LeadTime",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
