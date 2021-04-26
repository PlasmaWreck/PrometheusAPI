using Microsoft.EntityFrameworkCore.Migrations;

namespace PrometheusAPI.Migrations
{
    public partial class GraphicsCardModelperfect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemoryBandwith",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "MotherBoardInterface",
                table: "GraphicsCards");

            migrationBuilder.AlterColumn<string>(
                name: "ThermalDesignPower",
                table: "GraphicsCards",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "GraphicsCards",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "MemorySize",
                table: "GraphicsCards",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CoreClockSpeed",
                table: "GraphicsCards",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ComputePerformance",
                table: "GraphicsCards",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "MemoryBandwidth",
                table: "GraphicsCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemoryBus",
                table: "GraphicsCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemorySpeed",
                table: "GraphicsCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PowerConnectors",
                table: "GraphicsCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuggestedPSU",
                table: "GraphicsCards",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ComputePerformance", "CoreClockSpeed", "ImagePath", "MemoryBandwidth", "MemoryBus", "MemorySize", "MemorySpeed", "Name", "PowerConnectors", "Price", "SuggestedPSU", "ThermalDesignPower", "VideoOutputPorts" },
                values: new object[] { "8.873 TFLOPS", "1607 MHz", "/graphicscards/nvidiageforcegtx1080", "320.3 GB/s", "256 bit", "8 GB", "1251MHz", "NVIDIA GeForce GTX 1080", "1x 8-pin", "599 USD", "450 W", "180 W", "[\"1x DVI\",\"1x DisplayPort\",\"1x DisplayPort\",\"1x DisplayPort\",\"1x HDMI\"]" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemoryBandwidth",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "MemoryBus",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "MemorySpeed",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "PowerConnectors",
                table: "GraphicsCards");

            migrationBuilder.DropColumn(
                name: "SuggestedPSU",
                table: "GraphicsCards");

            migrationBuilder.AlterColumn<int>(
                name: "ThermalDesignPower",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "GraphicsCards",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemorySize",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CoreClockSpeed",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ComputePerformance",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemoryBandwith",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotherBoardInterface",
                table: "GraphicsCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ComputePerformance", "CoreClockSpeed", "ImagePath", "MemoryBandwith", "MemorySize", "MotherBoardInterface", "Name", "Price", "ThermalDesignPower", "VideoOutputPorts" },
                values: new object[] { 9, 1607, null, 320, 8, 256, "GeForce GTX 1080", 1499f, 180, "" });
        }
    }
}
