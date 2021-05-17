using Microsoft.EntityFrameworkCore.Migrations;

namespace PrometheusAPI.Migrations
{
    public partial class Processmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    CoreCount = table.Column<int>(nullable: false),
                    ThreadCount = table.Column<int>(nullable: false),
                    Transistors = table.Column<string>(nullable: true),
                    Frequency = table.Column<string>(nullable: true),
                    BaseClock = table.Column<string>(nullable: true),
                    PCIExpress = table.Column<string>(nullable: true),
                    Socket = table.Column<string>(nullable: true),
                    MaxTemp = table.Column<string>(nullable: true),
                    IntegratedGraphics = table.Column<string>(nullable: true),
                    MemorySupport = table.Column<string>(nullable: true),
                    ThermalDesignPower = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Processors",
                columns: new[] { "Id", "BaseClock", "Brand", "CoreCount", "Frequency", "ImagePath", "IntegratedGraphics", "MaxTemp", "MemorySupport", "Name", "PCIExpress", "Price", "Socket", "ThermalDesignPower", "ThreadCount", "Transistors" },
                values: new object[] { 1, "100 Mhz", "AMD", 6, "3.6 GHz", "/processors/amdryzen53600", "N/A", "95C", "DDR4-3200 MHz Dual-channel", "AMD Ryzen 5 3600", "Gen 4", "$0", "AMD Socket AM4", "65 W", 12, "3,800 million" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processors");
        }
    }
}
