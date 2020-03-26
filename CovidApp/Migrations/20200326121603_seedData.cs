using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidApp.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AccessionRecord",
                columns: new[] { "Id", "AccessionNumber", "AccessionVersion", "CollectionDate", "Country", "Orf1abSequence", "Orf3aSequence", "Region", "SurfaceGlycoproteinSequence" },
                values: new object[,]
                {
                    { -1, "MN908947", 3, "DEC-2019", "CN", "AAAAAA", "AAAAAA", "Wuhan", "AAAAAA" },
                    { -2, "MN988668", 1, "02-Jan-2020", "CN", "AAAAAW", "AAAWWW", null, "AAAAWA" },
                    { -3, "LC528232", 1, "2020-02-10", "JP", "AAAAAA", "WAAWWA", null, "AAAWAA" },
                    { -4, "MN988713", 1, "21-Jan-2020", "US", "AWAWAW", "WWWAAA", "IL", "AAAWWW" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccessionRecord",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "AccessionRecord",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "AccessionRecord",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "AccessionRecord",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
