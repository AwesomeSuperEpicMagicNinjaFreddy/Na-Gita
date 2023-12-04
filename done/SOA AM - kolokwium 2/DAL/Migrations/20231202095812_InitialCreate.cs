using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gracze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nick = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Narodowosc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gracze", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wydawnictwa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Siedziba = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wydawnictwa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RokWydania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WydawnictwoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gry_Wydawnictwa_WydawnictwoId",
                        column: x => x.WydawnictwoId,
                        principalTable: "Wydawnictwa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GraGracz",
                columns: table => new
                {
                    GraczeId = table.Column<int>(type: "int", nullable: false),
                    GryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraGracz", x => new { x.GraczeId, x.GryId });
                    table.ForeignKey(
                        name: "FK_GraGracz_Gracze_GraczeId",
                        column: x => x.GraczeId,
                        principalTable: "Gracze",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GraGracz_Gry_GryId",
                        column: x => x.GryId,
                        principalTable: "Gry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GraGracz_GryId",
                table: "GraGracz",
                column: "GryId");

            migrationBuilder.CreateIndex(
                name: "IX_Gry_WydawnictwoId",
                table: "Gry",
                column: "WydawnictwoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GraGracz");

            migrationBuilder.DropTable(
                name: "Gracze");

            migrationBuilder.DropTable(
                name: "Gry");

            migrationBuilder.DropTable(
                name: "Wydawnictwa");
        }
    }
}
