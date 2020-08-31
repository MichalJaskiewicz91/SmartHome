using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartHome.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "ImageThumbnailUrl", "ImageUrl", "IsNew", "LongDescription", "Name", "SectionId", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", true, null, "Lighting source", null, "Lighting source for instance - LED" },
                    { 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", true, null, "Pump", null, "Pump that allows water flow" },
                    { 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", false, null, "Roller blind", null, "Roller blind that allows window covering" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "SectionId", "Description", "SectionName" },
                values: new object[,]
                {
                    { 1, "Lighting", "Electricity" },
                    { 2, "Heating and Air conditioning", "HVAC" },
                    { 3, "Rest od controlled devices", "Others" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 3);
        }
    }
}
