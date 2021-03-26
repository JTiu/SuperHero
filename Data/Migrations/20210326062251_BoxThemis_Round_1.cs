using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroesNew.Data.Migrations
{
    public partial class BoxThemis_Round_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SuperHeroes",
                newName: "Round_1_B1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Round_1_B1",
                table: "SuperHeroes",
                newName: "Name");
        }
    }
}
