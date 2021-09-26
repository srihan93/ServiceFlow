using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceFlow.Webhost.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mtr_Reason",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mtr_Reason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mtr_Status",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mtr_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mpp_ReasonInStatus",
                columns: table => new
                {
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Mpp_ReasonInStatus_Mtr_Reason_ReasonId",
                        column: x => x.ReasonId,
                        principalTable: "Mtr_Reason",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mpp_ReasonInStatus_Mtr_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Mtr_Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mpp_ReasonInStatus_ReasonId",
                table: "Mpp_ReasonInStatus",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Mpp_ReasonInStatus_StatusId",
                table: "Mpp_ReasonInStatus",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mpp_ReasonInStatus");

            migrationBuilder.DropTable(
                name: "Mtr_Reason");

            migrationBuilder.DropTable(
                name: "Mtr_Status");
        }
    }
}
