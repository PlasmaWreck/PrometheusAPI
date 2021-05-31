using Microsoft.EntityFrameworkCore.Migrations;

namespace PrometheusAPI.Migrations
{
    public partial class AddedImgPathColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Motherboards",
                table: "Motherboards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAses",
                table: "CAses");

            migrationBuilder.RenameTable(
                name: "Motherboards",
                newName: "MotherBoards");

            migrationBuilder.RenameTable(
                name: "CAses",
                newName: "Cases");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "PowerSupplies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "OpticalDrives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "OperatingSystems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "MotherBoards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Memories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "HardDrives",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Coolers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Cases",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotherBoards",
                table: "MotherBoards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cases",
                table: "Cases",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MotherBoards",
                table: "MotherBoards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cases",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "PowerSupplies");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "OpticalDrives");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "OperatingSystems");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Memories");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "HardDrives");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Coolers");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Cases");

            migrationBuilder.RenameTable(
                name: "MotherBoards",
                newName: "Motherboards");

            migrationBuilder.RenameTable(
                name: "Cases",
                newName: "CAses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motherboards",
                table: "Motherboards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAses",
                table: "CAses",
                column: "Id");
        }
    }
}
