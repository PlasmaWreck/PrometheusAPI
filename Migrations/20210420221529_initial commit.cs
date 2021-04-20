using Microsoft.EntityFrameworkCore.Migrations;

namespace PrometheusAPI.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GraphicsCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    CoreCount = table.Column<int>(nullable: false),
                    CoreClockSpeed = table.Column<int>(nullable: false),
                    MemoryType = table.Column<string>(nullable: true),
                    MemorySize = table.Column<int>(nullable: false),
                    MemoryBandwith = table.Column<int>(nullable: false),
                    MotherBoardInterface = table.Column<int>(nullable: false),
                    ThermalDesignPower = table.Column<int>(nullable: false),
                    PowerConnectors = table.Column<string>(nullable: true),
                    VideoOutputPorts = table.Column<string>(nullable: true),
                    APISupport = table.Column<string>(nullable: true),
                    ComputePerformance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicsCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "APISupport", "ComputePerformance", "CoreClockSpeed", "CoreCount", "GPU", "MemoryBandwith", "MemorySize", "MemoryType", "MotherBoardInterface", "Name", "PowerConnectors", "ThermalDesignPower", "VideoOutputPorts" },
                values: new object[] { 1, "", 9, 1607, 2560, "NVIDIA", 320, 8, "GDDR5X", 256, "GeForce GTX 1080", "", 180, "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "password", "Angel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GraphicsCards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
