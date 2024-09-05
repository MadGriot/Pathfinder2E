using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class cuttingLore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lore",
                table: "Skills");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Lore",
                table: "Skills",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillsId",
                keyValue: 1,
                column: "Lore",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillsId",
                keyValue: 2,
                column: "Lore",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillsId",
                keyValue: 3,
                column: "Lore",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillsId",
                keyValue: 4,
                column: "Lore",
                value: 0);
        }
    }
}
