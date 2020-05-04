using Microsoft.EntityFrameworkCore.Migrations;

namespace UpCycling.Data.Migrations
{
    public partial class lieuetplace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lieu",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Place",
                table: "Event",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lieu",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Event");
        }
    }
}
