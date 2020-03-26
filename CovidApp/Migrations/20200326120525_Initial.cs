using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessionRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessionNumber = table.Column<string>(nullable: false),
                    AccessionVersion = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Region = table.Column<string>(nullable: true),
                    CollectionDate = table.Column<string>(nullable: true),
                    Orf1abSequence = table.Column<string>(nullable: true),
                    SurfaceGlycoproteinSequence = table.Column<string>(nullable: true),
                    Orf3aSequence = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessionRecord", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessionRecord");
        }
    }
}
