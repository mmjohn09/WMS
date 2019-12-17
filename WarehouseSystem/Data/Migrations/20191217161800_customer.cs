using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseSystem.Data.Migrations
{
    public partial class customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier_SupplierId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier_SupplierId",
                table: "Product",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Supplier_SupplierId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Supplier_SupplierId",
                table: "Product",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
