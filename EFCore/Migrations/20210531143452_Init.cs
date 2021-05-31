using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bid",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExpectedAllocation_Capacity_Value_Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExpectedAllocation_Capacity_Confirmed = table.Column<bool>(type: "bit", nullable: true),
                    ActualAllocation_Capacity_Value_Value = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ActualAllocation_Capacity_Confirmed = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bid");
        }
    }
}
