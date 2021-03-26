using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroesNew.Data.Migrations
{
    public partial class More_rounds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecondaryAbility",
                table: "SuperHeroes",
                newName: "Round_3_B2");

            migrationBuilder.RenameColumn(
                name: "DisguiseOutfit",
                table: "SuperHeroes",
                newName: "Round_3_B1");

            migrationBuilder.RenameColumn(
                name: "CatchPhrase",
                table: "SuperHeroes",
                newName: "Round_2_B2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Round_3_B2",
                table: "SuperHeroes",
                newName: "SecondaryAbility");

            migrationBuilder.RenameColumn(
                name: "Round_3_B1",
                table: "SuperHeroes",
                newName: "DisguiseOutfit");

            migrationBuilder.RenameColumn(
                name: "Round_2_B2",
                table: "SuperHeroes",
                newName: "CatchPhrase");
        }
    }
}
