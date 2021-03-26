using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroesNew.Data.Migrations
{
    public partial class added812 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Round_10_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_10_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_11_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_11_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_12_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_12_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_5_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_5_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_6_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_6_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_7_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_7_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_8_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_8_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_9_B1",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Round_9_B2",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Round_10_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_10_B2",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_11_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_11_B2",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_12_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_12_B2",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_5_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_5_B2",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_6_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_6_B2",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_7_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_7_B2",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_8_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_8_B2",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_9_B1",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Round_9_B2",
                table: "SuperHeroes");
        }
    }
}
