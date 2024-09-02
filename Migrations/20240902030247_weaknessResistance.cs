using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class weaknessResistance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "resistances",
                table: "CharacterSheets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "weaknesses",
                table: "CharacterSheets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 1,
                columns: new[] { "resistances", "weaknesses" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 2,
                columns: new[] { "resistances", "weaknesses" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 3,
                columns: new[] { "resistances", "weaknesses" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "resistances",
                table: "CharacterSheets");

            migrationBuilder.DropColumn(
                name: "weaknesses",
                table: "CharacterSheets");
        }
    }
}
