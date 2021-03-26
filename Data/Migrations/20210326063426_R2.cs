using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroesNew.Data.Migrations
{
    public partial class R2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlterEgo",
                table: "SuperHeroes",
                newName: "Round_1_B2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Round_1_B2",
                table: "SuperHeroes",
                newName: "AlterEgo");
        }
    }
}
