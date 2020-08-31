using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartHome.Migrations
{
    public partial class NotesAddedOnDevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Devices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Devices");
        }
    }
}
