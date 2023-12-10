using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DominC11.Migrations
{
    /// <inheritdoc />
    public partial class Test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPart_Parts_PartsId",
                table: "CarPart");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_customerId",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Sales",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_customerId",
                table: "Sales",
                newName: "IX_Sales_CustomerId");

            migrationBuilder.RenameColumn(
                name: "PartsId",
                table: "CarPart",
                newName: "PartId");

            migrationBuilder.RenameIndex(
                name: "IX_CarPart_PartsId",
                table: "CarPart",
                newName: "IX_CarPart_PartId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPart_Parts_PartId",
                table: "CarPart",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPart_Parts_PartId",
                table: "CarPart");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Sales",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                newName: "IX_Sales_customerId");

            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "CarPart",
                newName: "PartsId");

            migrationBuilder.RenameIndex(
                name: "IX_CarPart_PartId",
                table: "CarPart",
                newName: "IX_CarPart_PartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPart_Parts_PartsId",
                table: "CarPart",
                column: "PartsId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_customerId",
                table: "Sales",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
