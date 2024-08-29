using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterSheets",
                columns: table => new
                {
                    CharacterSheetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    level = table.Column<int>(type: "INTEGER", nullable: false),
                    firstName = table.Column<string>(type: "TEXT", nullable: false),
                    lastName = table.Column<string>(type: "TEXT", nullable: false),
                    currentHP = table.Column<int>(type: "INTEGER", nullable: false),
                    maxHP = table.Column<int>(type: "INTEGER", nullable: false),
                    ancestry = table.Column<int>(type: "INTEGER", nullable: false),
                    background = table.Column<int>(type: "INTEGER", nullable: false),
                    characterClass = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSheets", x => x.CharacterSheetId);
                });

            migrationBuilder.CreateTable(
                name: "AbilityScores",
                columns: table => new
                {
                    AbilityScoreId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterSheetId = table.Column<int>(type: "INTEGER", nullable: false),
                    strength = table.Column<int>(type: "INTEGER", nullable: false),
                    dexterity = table.Column<int>(type: "INTEGER", nullable: false),
                    constitution = table.Column<int>(type: "INTEGER", nullable: false),
                    intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    wisdom = table.Column<int>(type: "INTEGER", nullable: false),
                    charisma = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScores", x => x.AbilityScoreId);
                    table.ForeignKey(
                        name: "FK_AbilityScores_CharacterSheets_CharacterSheetId",
                        column: x => x.CharacterSheetId,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feat",
                columns: table => new
                {
                    FeatId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterSheetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feat", x => x.FeatId);
                    table.ForeignKey(
                        name: "FK_Feat_CharacterSheets_CharacterSheetId",
                        column: x => x.CharacterSheetId,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterSheetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_CharacterSheets_CharacterSheetId",
                        column: x => x.CharacterSheetId,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CharacterSheets",
                columns: new[] { "CharacterSheetId", "ancestry", "background", "characterClass", "currentHP", "firstName", "lastName", "level", "maxHP" },
                values: new object[,]
                {
                    { 1, 1, 27, 8, 15, "Konjit", "Munaye", 1, 15 },
                    { 2, 6, 22, 1, 22, "Kanandi", "Oladoyinbo", 1, 22 },
                    { 3, 6, 11, 11, 14, "Cris", "Marcellus", 1, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScores_CharacterSheetId",
                table: "AbilityScores",
                column: "CharacterSheetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feat_CharacterSheetId",
                table: "Feat",
                column: "CharacterSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CharacterSheetId",
                table: "Item",
                column: "CharacterSheetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityScores");

            migrationBuilder.DropTable(
                name: "Feat");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "CharacterSheets");
        }
    }
}
