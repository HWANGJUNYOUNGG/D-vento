using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class M9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "p_comprice",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "p_location",
                table: "Product",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "p_many",
                table: "Product",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "p_comprice",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "p_location",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "p_many",
                table: "Product");
        }
    }
}
