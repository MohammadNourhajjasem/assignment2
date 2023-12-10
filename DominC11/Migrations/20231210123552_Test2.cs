using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DominC11.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPart_Parts_partsId",
                table: "CarPart");

            migrationBuilder.RenameColumn(
                name: "partsId",
                table: "CarPart",
                newName: "PartsId");

            migrationBuilder.RenameIndex(
                name: "IX_CarPart_partsId",
                table: "CarPart",
                newName: "IX_CarPart_PartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPart_Parts_PartsId",
                table: "CarPart",
                column: "PartsId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPart_Parts_PartsId",
                table: "CarPart");

            migrationBuilder.RenameColumn(
                name: "PartsId",
                table: "CarPart",
                newName: "partsId");

            migrationBuilder.RenameIndex(
                name: "IX_CarPart_PartsId",
                table: "CarPart",
                newName: "IX_CarPart_partsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPart_Parts_partsId",
                table: "CarPart",
                column: "partsId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
