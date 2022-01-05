using Microsoft.EntityFrameworkCore.Migrations;

namespace LumberManagerWebEdition.Data.Migrations
{
    public partial class ShipAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShipAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipCity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipState",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipZipCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipCity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipState",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipZipCode",
                table: "Orders");
        }
    }
}
