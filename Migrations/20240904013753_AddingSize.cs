using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class AddingSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "size",
                table: "CharacterSheets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 1,
                column: "size",
                value: 0);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 2,
                column: "size",
                value: 0);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 3,
                column: "size",
                value: 0);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 4,
                column: "size",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "size",
                table: "CharacterSheets");
        }
    }
}
