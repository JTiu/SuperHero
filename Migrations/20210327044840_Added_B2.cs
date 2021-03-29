using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroesNew.Migrations
{
    public partial class Added_B2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "SuperHeroes",
                newName: "Total_B2");

            migrationBuilder.AddColumn<int>(
                name: "Total_B1",
                table: "SuperHeroes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total_B1",
                table: "SuperHeroes");

            migrationBuilder.RenameColumn(
                name: "Total_B2",
                table: "SuperHeroes",
                newName: "Total");
        }
    }
}
