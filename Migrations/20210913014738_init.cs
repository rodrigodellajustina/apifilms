using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFilms.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    year = table.Column<string>(type: "TEXT", maxLength: 4, nullable: true),
                    studios = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    producers = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    winner = table.Column<string>(type: "TEXT", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "id", "producers", "studios", "title", "winner", "year" },
                values: new object[] { -999, "teste producers", "teste studios", "teste title", "year", "2021" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
