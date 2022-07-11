using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Organista.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ID = table.Column<ulong>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Mass = table.Column<byte>(type: "INTEGER", nullable: false),
                    Devotion = table.Column<byte>(type: "INTEGER", nullable: false),
                    Hours = table.Column<byte>(type: "INTEGER", nullable: false),
                    Cross = table.Column<byte>(type: "INTEGER", nullable: false),
                    Bitter = table.Column<byte>(type: "INTEGER", nullable: false),
                    Funeral = table.Column<byte>(type: "INTEGER", nullable: false),
                    Wedding = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SetNames",
                columns: table => new
                {
                    ID = table.Column<ulong>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetNames", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    ID = table.Column<ulong>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NameID = table.Column<ulong>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sets_SetNames_NameID",
                        column: x => x.NameID,
                        principalTable: "SetNames",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cantos",
                columns: table => new
                {
                    ID = table.Column<ulong>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 260, nullable: false),
                    SetID = table.Column<ulong>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cantos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cantos_Sets_SetID",
                        column: x => x.SetID,
                        principalTable: "Sets",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cantos_SetID",
                table: "Cantos",
                column: "SetID");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_NameID",
                table: "Sets",
                column: "NameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Cantos");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "SetNames");
        }
    }
}
