using Microsoft.EntityFrameworkCore.Migrations;

namespace SpryStore.DataAccessLayer.Migrations
{
    public partial class about_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutFb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutIns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutBh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
