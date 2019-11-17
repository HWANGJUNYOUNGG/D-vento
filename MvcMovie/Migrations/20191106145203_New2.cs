using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class New2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    p_code = table.Column<string>(nullable: false),
                    p_name = table.Column<string>(nullable: false),
                    p_measure = table.Column<int>(nullable: false),
                    p_amount = table.Column<string>(nullable: false),
                    p_brandname = table.Column<string>(nullable: false),
                    p_customerprice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.p_code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
