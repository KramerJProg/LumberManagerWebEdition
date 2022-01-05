using Microsoft.EntityFrameworkCore.Migrations;

namespace LumberManagerWebEdition.Data.Migrations
{
    public partial class BoardFeet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BoardFeet",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoardFeet",
                table: "Products");
        }
    }
}
