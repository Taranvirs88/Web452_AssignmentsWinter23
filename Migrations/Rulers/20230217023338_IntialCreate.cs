using Microsoft.EntityFrameworkCore.Migrations;

namespace Rulers.Migrations.Rulers
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ruler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RulerTypes = table.Column<string>(nullable: true),
                    Colour = table.Column<string>(nullable: true),
                    RulerShape = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    MeasurementSystem = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ruler");
        }
    }
}
