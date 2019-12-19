using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseSystem.Data.Migrations
{
    public partial class purchaseOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "PoNumber",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Purchase",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Purchase");

            migrationBuilder.AlterColumn<string>(
                name: "PoNumber",
                table: "Purchase",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Purchase",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
