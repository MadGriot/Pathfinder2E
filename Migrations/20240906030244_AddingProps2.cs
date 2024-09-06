using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathfinder2E.Migrations
{
    /// <inheritdoc />
    public partial class AddingProps2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Longsword",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Occult_Spell_Attacks",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Occult_Spell_DCs",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rapier",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sap",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Shortbow",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Shortsword",
                table: "Proficiencies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Longsword",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Occult_Spell_Attacks",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Occult_Spell_DCs",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Rapier",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Sap",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Shortbow",
                table: "Proficiencies");

            migrationBuilder.DropColumn(
                name: "Shortsword",
                table: "Proficiencies");
        }
    }
}
