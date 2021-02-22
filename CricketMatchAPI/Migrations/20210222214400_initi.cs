using Microsoft.EntityFrameworkCore.Migrations;

namespace CricketMatchAPI.Migrations
{
    public partial class initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    player_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    player_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    player_Score = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    player_Age = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
