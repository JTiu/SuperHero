using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroesNew.Data.Migrations
{
    public partial class r2b1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrimaryAbility",
                table: "SuperHeroes",
                newName: "Round_2_B1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Round_2_B1",
                table: "SuperHeroes",
                newName: "PrimaryAbility");
        }
    }
}
