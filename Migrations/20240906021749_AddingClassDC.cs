using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class AddingClassDC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassDCs",
                columns: table => new
                {
                    ClassDCsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterSheetId = table.Column<int>(type: "INTEGER", nullable: false),
                    Alchemist = table.Column<int>(type: "INTEGER", nullable: false),
                    Barbarian = table.Column<int>(type: "INTEGER", nullable: false),
                    Bard = table.Column<int>(type: "INTEGER", nullable: false),
                    Champion = table.Column<int>(type: "INTEGER", nullable: false),
                    Cleric = table.Column<int>(type: "INTEGER", nullable: false),
                    Druid = table.Column<int>(type: "INTEGER", nullable: false),
                    Fighter = table.Column<int>(type: "INTEGER", nullable: false),
                    Monk = table.Column<int>(type: "INTEGER", nullable: false),
                    Ranger = table.Column<int>(type: "INTEGER", nullable: false),
                    Rogue = table.Column<int>(type: "INTEGER", nullable: false),
                    Sorcerer = table.Column<int>(type: "INTEGER", nullable: false),
                    Wizard = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassDCs", x => x.ClassDCsId);
                    table.ForeignKey(
                        name: "FK_ClassDCs_CharacterSheets_CharacterSheetId",
                        column: x => x.CharacterSheetId,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassDCs_CharacterSheetId",
                table: "ClassDCs",
                column: "CharacterSheetId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassDCs");
        }
    }
}
