using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroesNew.Data.Migrations
{
    public partial class Added_DisguiseOutfit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisguiseOutfit",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisguiseOutfit",
                table: "SuperHeroes");
        }
    }
}
