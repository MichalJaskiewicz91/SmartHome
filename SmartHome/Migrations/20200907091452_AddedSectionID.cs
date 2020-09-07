using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartHome.Migrations
{
    public partial class AddedSectionID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Sections_SectionId",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Devices",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                column: "SectionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2,
                column: "SectionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3,
                column: "SectionId",
                value: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Sections_SectionId",
                table: "Devices",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Sections_SectionId",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "Devices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                column: "SectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2,
                column: "SectionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3,
                column: "SectionId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Sections_SectionId",
                table: "Devices",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
