using Microsoft.EntityFrameworkCore.Migrations;

namespace PrometheusAPI.Migrations
{
    public partial class MadeSavedBuildsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavedBuilds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseId = table.Column<int>(nullable: true),
                    CoolerId = table.Column<int>(nullable: true),
                    GraphicsCardId = table.Column<int>(nullable: true),
                    HardDriveId = table.Column<int>(nullable: true),
                    LoginId = table.Column<int>(nullable: true),
                    MemoryId = table.Column<int>(nullable: true),
                    MotherBoardId = table.Column<int>(nullable: true),
                    OSId = table.Column<int>(nullable: true),
                    PowerSupplyId = table.Column<int>(nullable: true),
                    ProcessorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedBuilds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_Cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Cases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_Coolers_CoolerId",
                        column: x => x.CoolerId,
                        principalTable: "Coolers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_GraphicsCards_GraphicsCardId",
                        column: x => x.GraphicsCardId,
                        principalTable: "GraphicsCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_HardDrives_HardDriveId",
                        column: x => x.HardDriveId,
                        principalTable: "HardDrives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_Users_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_Memories_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_MotherBoards_MotherBoardId",
                        column: x => x.MotherBoardId,
                        principalTable: "MotherBoards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_OperatingSystems_OSId",
                        column: x => x.OSId,
                        principalTable: "OperatingSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_PowerSupplies_PowerSupplyId",
                        column: x => x.PowerSupplyId,
                        principalTable: "PowerSupplies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedBuilds_Processors_ProcessorId",
                        column: x => x.ProcessorId,
                        principalTable: "Processors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_CaseId",
                table: "SavedBuilds",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_CoolerId",
                table: "SavedBuilds",
                column: "CoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_GraphicsCardId",
                table: "SavedBuilds",
                column: "GraphicsCardId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_HardDriveId",
                table: "SavedBuilds",
                column: "HardDriveId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_LoginId",
                table: "SavedBuilds",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_MemoryId",
                table: "SavedBuilds",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_MotherBoardId",
                table: "SavedBuilds",
                column: "MotherBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_OSId",
                table: "SavedBuilds",
                column: "OSId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_PowerSupplyId",
                table: "SavedBuilds",
                column: "PowerSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedBuilds_ProcessorId",
                table: "SavedBuilds",
                column: "ProcessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedBuilds");
        }
    }
}
