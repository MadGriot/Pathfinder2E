using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class newCharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CharacterSheets",
                columns: new[] { "CharacterSheetId", "XP", "alignment", "ancestry", "background", "characterClass", "currentHP", "firstName", "lastName", "level", "maxHP", "resistanceValues", "resistances", "speed", "weaknessValues", "weaknesses" },
                values: new object[] { 4, 0, 0, 6, 28, 6, 0, "Unkown", "Person", 1, 0, null, null, 25, null, null });

            migrationBuilder.InsertData(
                table: "AbilityScores",
                columns: new[] { "AbilityScoreId", "CharacterSheetId", "charisma", "constitution", "dexterity", "intelligence", "strength", "wisdom" },
                values: new object[] { 4, 4, 10, 10, 10, 10, 10, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AbilityScores",
                keyColumn: "AbilityScoreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 4);
        }
    }
}
