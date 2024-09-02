using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class weakResistValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "resistanceValues",
                table: "CharacterSheets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "weaknessValues",
                table: "CharacterSheets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 1,
                columns: new[] { "resistanceValues", "weaknessValues" },
                values: new object[] { "[2,2]", null });

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 2,
                columns: new[] { "resistanceValues", "weaknessValues" },
                values: new object[] { null, "[3,2]" });

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 3,
                columns: new[] { "resistanceValues", "weaknessValues" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "resistanceValues",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "weaknessValues",
                table: "CharacterSheets");
        }
    }
}
