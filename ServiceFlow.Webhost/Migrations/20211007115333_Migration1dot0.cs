using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceFlow.Webhost.Migrations
{
    public partial class Migration1dot0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mtr_Attribute",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mtr_Attribute", x => x.Id);
                });

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
                name: "Mtr_Workflow",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mtr_Workflow", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Mtr_WorkflowConfiguration",
                columns: table => new
                {
                    WorkflowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NextStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsStart = table.Column<bool>(type: "bit", nullable: false),
                    IsEnd = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Mtr_WorkflowConfiguration_Mtr_Status_CurrentStatusId",
                        column: x => x.CurrentStatusId,
                        principalTable: "Mtr_Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Mtr_WorkflowConfiguration_Mtr_Status_NextStatusId",
                        column: x => x.NextStatusId,
                        principalTable: "Mtr_Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Mtr_WorkflowConfiguration_Mtr_Workflow_WorkflowId",
                        column: x => x.WorkflowId,
                        principalTable: "Mtr_Workflow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mpp_ReasonInStatus_ReasonId",
                table: "Mpp_ReasonInStatus",
                column: "ReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Mpp_ReasonInStatus_StatusId",
                table: "Mpp_ReasonInStatus",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Mtr_WorkflowConfiguration_CurrentStatusId",
                table: "Mtr_WorkflowConfiguration",
                column: "CurrentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Mtr_WorkflowConfiguration_NextStatusId",
                table: "Mtr_WorkflowConfiguration",
                column: "NextStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Mtr_WorkflowConfiguration_WorkflowId",
                table: "Mtr_WorkflowConfiguration",
                column: "WorkflowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mpp_ReasonInStatus");

            migrationBuilder.DropTable(
                name: "Mtr_Attribute");

            migrationBuilder.DropTable(
                name: "Mtr_WorkflowConfiguration");

            migrationBuilder.DropTable(
                name: "Mtr_Reason");

            migrationBuilder.DropTable(
                name: "Mtr_Status");

            migrationBuilder.DropTable(
                name: "Mtr_Workflow");
        }
    }
}