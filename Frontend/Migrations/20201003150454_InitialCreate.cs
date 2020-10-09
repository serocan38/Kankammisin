using Microsoft.EntityFrameworkCore.Migrations;

namespace Frontend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testler",
                columns: table => new
                {
                    TestId = table.Column<int>(nullable: false),
                    TestAdi = table.Column<string>(nullable: true),
                    TestLinki = table.Column<string>(nullable: true),
                    TestSahibi = table.Column<string>(nullable: true),
                    TestSoruSayisi = table.Column<string>(nullable: true),
                    TestCozulmeSayisi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testler", x => x.TestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testler");
        }
    }
}
