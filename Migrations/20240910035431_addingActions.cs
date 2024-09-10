using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class addingActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Arcane_Spell_Attacks",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Arcane_Spell_DC",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Club",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Crossbow",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dagger",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Divine_Spell_Attacks",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Divine_Spell_DC",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Heavy_Crossbow",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Primal_Spell_Attacks",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Primal_Spell_DCs",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Staff",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MyAction",
                columns: table => new
                {
                    MyActionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CharacterSheetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyAction", x => x.MyActionId);
                    table.ForeignKey(
                        name: "FK_MyAction_CharacterSheets_CharacterSheetId",
                        column: x => x.CharacterSheetId,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyAction_CharacterSheetId",
                table: "MyAction",
                column: "CharacterSheetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyAction");

            migrationBuilder.DropColumn(
                name: "Arcane_Spell_Attacks",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Arcane_Spell_DC",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Club",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Crossbow",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Dagger",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Divine_Spell_Attacks",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Divine_Spell_DC",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Heavy_Crossbow",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Primal_Spell_Attacks",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Primal_Spell_DCs",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Staff",
                table: "Proficiencies");
        }
    }
}
