using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseSystem.Data.Migrations
{
    public partial class invoiceNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Invoice_invoiceId",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "invoiceId",
                table: "Purchase",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Invoice_invoiceId",
                table: "Purchase",
                column: "invoiceId",
                principalTable: "Invoice",
                principalColumn: "invoiceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Invoice_invoiceId",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "invoiceId",
                table: "Purchase",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Invoice_invoiceId",
                table: "Purchase",
                column: "invoiceId",
                principalTable: "Invoice",
                principalColumn: "invoiceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
