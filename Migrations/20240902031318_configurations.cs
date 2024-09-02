using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class configurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 1,
                column: "resistances",
                value: "[2,4]");

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 2,
                column: "weaknesses",
                value: "[1,2]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 1,
                column: "resistances",
                value: null);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 2,
                column: "weaknesses",
                value: null);
        }
    }
}
