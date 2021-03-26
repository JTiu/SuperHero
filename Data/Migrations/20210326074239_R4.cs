using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroesNew.Data.Migrations
{
    public partial class R4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Round_4_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_4_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Round_4_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_4_B2",
                table: "SuperHeroes");
        }
    }
}
