using Microsoft.EntityFrameworkCore.Migrations;

namespace PrometheusAPI.Migrations
{
    public partial class AddedImgagePathToGraphicsCards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "GraphicsCards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "GraphicsCards");
        }
    }
}
