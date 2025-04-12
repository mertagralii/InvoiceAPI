using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class InvoiceForInKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_InvoiceStatuses_InvoiceStatusId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_InvoiceStatusId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoiceStatusId",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_StatusId",
                table: "Invoices",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_InvoiceStatuses_StatusId",
                table: "Invoices",
                column: "StatusId",
                principalTable: "InvoiceStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_InvoiceStatuses_StatusId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_StatusId",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceStatusId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceStatusId",
                table: "Invoices",
                column: "InvoiceStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_InvoiceStatuses_InvoiceStatusId",
                table: "Invoices",
                column: "InvoiceStatusId",
                principalTable: "InvoiceStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
