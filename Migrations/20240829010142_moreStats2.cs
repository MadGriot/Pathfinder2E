using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class moreStats2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AbilityScores",
                columns: new[] { "AbilityScoreId", "CharacterSheetId", "charisma", "constitution", "dexterity", "intelligence", "strength", "wisdom" },
                values: new object[,]
                {
                    { 1, 1, 10, 10, 10, 10, 10, 10 },
                    { 2, 2, 10, 10, 10, 10, 10, 10 },
                    { 3, 3, 10, 10, 10, 10, 10, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AbilityScores",
                keyColumn: "AbilityScoreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AbilityScores",
                keyColumn: "AbilityScoreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AbilityScores",
                keyColumn: "AbilityScoreId",
                keyValue: 3);
        }
    }
}
