using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseSystem.Data.Migrations
{
    public partial class removedSupplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Supplier_SupplierId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Invoice_invoiceId",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "invoiceId",
                table: "Purchase",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Purchase",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Supplier_SupplierId",
                table: "Purchase",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Invoice_invoiceId",
                table: "Purchase",
                column: "invoiceId",
                principalTable: "Invoice",
                principalColumn: "invoiceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Supplier_SupplierId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Invoice_invoiceId",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "invoiceId",
                table: "Purchase",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Purchase",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Supplier_SupplierId",
                table: "Purchase",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Invoice_invoiceId",
                table: "Purchase",
                column: "invoiceId",
                principalTable: "Invoice",
                principalColumn: "invoiceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
