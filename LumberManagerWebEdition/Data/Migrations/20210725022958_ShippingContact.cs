using Microsoft.EntityFrameworkCore.Migrations;

namespace LumberManagerWebEdition.Data.Migrations
{
    public partial class ShippingContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShipBusiness",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipContactFirstName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipContactLastName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipBusiness",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipContactFirstName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipContactLastName",
                table: "Orders");
        }
    }
}
