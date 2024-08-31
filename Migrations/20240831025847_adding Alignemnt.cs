using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class addingAlignemnt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "alignment",
                table: "CharacterSheets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 1,
                column: "alignment",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 2,
                column: "alignment",
                value: 6);

            migrationBuilder.UpdateData(
                table: "CharacterSheets",
                keyColumn: "CharacterSheetId",
                keyValue: 3,
                column: "alignment",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alignment",
                table: "CharacterSheets");
        }
    }
}
