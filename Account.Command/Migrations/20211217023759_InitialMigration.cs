using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Account.Command.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventTable",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    timeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    aggregationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aggregateType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    version = table.Column<int>(type: "int", nullable: false),
                    eventType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTable", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventTable");
        }
    }
}
