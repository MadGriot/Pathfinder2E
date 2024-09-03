using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class SetUpAncestry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "XP",
                table: "CharacterSheets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "speed",
                table: "CharacterSheets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 1,
                columns: new[] { "XP", "speed" },
                values: new object[] { 0, 30 });

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 2,
                columns: new[] { "XP", "speed" },
                values: new object[] { 0, 25 });

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 3,
                columns: new[] { "XP", "speed" },
                values: new object[] { 0, 25 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "XP",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "speed",
                table: "CharacterSheets");
        }
    }
}
