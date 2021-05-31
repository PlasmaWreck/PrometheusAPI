using Microsoft.EntityFrameworkCore.Migrations;

namespace PrometheusAPI.Migrations
{
    public partial class RemainingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    MBFormFactor = table.Column<string>(nullable: true),
                    RGB = table.Column<bool>(nullable: false),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coolers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    NumOfFans = table.Column<string>(nullable: true),
                    LiquidCooling = table.Column<bool>(nullable: false),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coolers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardDrives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    DiskSize = table.Column<string>(nullable: true),
                    RPM = table.Column<string>(nullable: true),
                    ConnectionType = table.Column<string>(nullable: true),
                    Interface = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDrives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    StickType = table.Column<string>(nullable: true),
                    CellType = table.Column<string>(nullable: true),
                    ClockFrequency = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    FormFactor = table.Column<string>(nullable: true),
                    CPUSocket = table.Column<string>(nullable: true),
                    Chipset = table.Column<string>(nullable: true),
                    USBPorts = table.Column<string>(nullable: true),
                    RAMSlots = table.Column<string>(nullable: true),
                    VideoConnectors = table.Column<string>(nullable: true),
                    PCIESlots = table.Column<string>(nullable: true),
                    InBuiltWifi = table.Column<string>(nullable: true),
                    Sata3Connectors = table.Column<string>(nullable: true),
                    M2NVMESupport = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    InstallMethod = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpticalDrives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    ConnectionType = table.Column<string>(nullable: true),
                    BluRay = table.Column<bool>(nullable: false),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpticalDrives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    Efficiency = table.Column<string>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    MainConnectorType = table.Column<string>(nullable: true),
                    Modular = table.Column<bool>(nullable: false),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAses");

            migrationBuilder.DropTable(
                name: "Coolers");

            migrationBuilder.DropTable(
                name: "HardDrives");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "OperatingSystems");

            migrationBuilder.DropTable(
                name: "OpticalDrives");

            migrationBuilder.DropTable(
                name: "PowerSupplies");
        }
    }
}
