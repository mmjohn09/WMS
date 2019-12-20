using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseSystem.Data.Migrations
{
    public partial class receipts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Purchase_PurchaseId",
                table: "Receipt");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseId",
                table: "Receipt",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QtyReceived",
                table: "Receipt",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Purchase_PurchaseId",
                table: "Receipt",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "PurchaseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Purchase_PurchaseId",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "QtyReceived",
                table: "Receipt");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseId",
                table: "Receipt",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Purchase_PurchaseId",
                table: "Receipt",
                column: "PurchaseId",
                principalTable: "Purchase",
                principalColumn: "PurchaseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
