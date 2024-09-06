using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class AddingProficiencies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proficiencies",
                columns: table => new
                {
                    ProficienciesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterSheetId = table.Column<int>(type: "INTEGER", nullable: false),
                    Advanced_Weapons = table.Column<int>(type: "INTEGER", nullable: false),
                    Fortitude = table.Column<int>(type: "INTEGER", nullable: false),
                    Heavy_Armor = table.Column<int>(type: "INTEGER", nullable: false),
                    Light_Armor = table.Column<int>(type: "INTEGER", nullable: false),
                    Martial_Weapons = table.Column<int>(type: "INTEGER", nullable: false),
                    Medium_Armor = table.Column<int>(type: "INTEGER", nullable: false),
                    Perception = table.Column<int>(type: "INTEGER", nullable: false),
                    Reflex = table.Column<int>(type: "INTEGER", nullable: false),
                    Simple_Weapons = table.Column<int>(type: "INTEGER", nullable: false),
                    Unarmed_Attacks = table.Column<int>(type: "INTEGER", nullable: false),
                    Unarmored_Defence = table.Column<int>(type: "INTEGER", nullable: false),
                    Will = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proficiencies", x => x.ProficienciesId);
                    table.ForeignKey(
                        name: "FK_Proficiencies_CharacterSheets_CharacterSheetId",
                        column: x => x.CharacterSheetId,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proficiencies_CharacterSheetId",
                table: "Proficiencies",
                column: "CharacterSheetId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proficiencies");
        }
    }
}
