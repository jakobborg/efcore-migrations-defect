using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinancialsRevenue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialsRevenue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerPurchaseAgreement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FinancialsRevenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fid = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerPurchaseAgreement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerPurchaseAgreement_FinancialsRevenue_FinancialsRevenueId",
                        column: x => x.FinancialsRevenueId,
                        principalTable: "FinancialsRevenue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PowerPurchaseAgreement_FinancialsRevenueId",
                table: "PowerPurchaseAgreement",
                column: "FinancialsRevenueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PowerPurchaseAgreement");

            migrationBuilder.DropTable(
                name: "FinancialsRevenue");
        }
    }
}
