using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartHome.Migrations
{
    public partial class NewNameForImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "E:\\Programowanie\\C#\\Projects\\ASP.NET CORE\\SmartHome\\SmartHome\\wwwroot\\images\\plug.png", "E:\\Programowanie\\C#\\Projects\\ASP.NET CORE\\SmartHome\\SmartHome\\wwwroot\\images\\plug.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "E:\\Programowanie\\C#\\Projects\\ASP.NET CORE\\SmartHome\\SmartHome\\wwwroot\\images", "E:\\Programowanie\\C#\\Projects\\ASP.NET CORE\\SmartHome\\SmartHome\\wwwroot\\images" });
        }
    }
}
