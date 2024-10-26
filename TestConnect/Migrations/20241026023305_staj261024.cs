using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestConnectDB.Migrations
{
    /// <inheritdoc />
    public partial class staj261024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sotrudnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fio = table.Column<string>(type: "TEXT", nullable: true),
                    FioBeforeMarry = table.Column<string>(type: "TEXT", nullable: true),
                    Marry = table.Column<bool>(type: "INTEGER", nullable: true),
                    Dater = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pol = table.Column<bool>(type: "INTEGER", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sotrudnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SotrudnikIdId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentsWork = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Sotrudnik_SotrudnikIdId",
                        column: x => x.SotrudnikIdId,
                        principalTable: "Sotrudnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SotrudnikIdId = table.Column<int>(type: "INTEGER", nullable: false),
                    BeginWorkSotrudnik = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndWorkSotrudnik = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GosWorkSotrudnik = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staj_Sotrudnik_SotrudnikIdId",
                        column: x => x.SotrudnikIdId,
                        principalTable: "Sotrudnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StajIdId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nomerreport = table.Column<string>(type: "TEXT", nullable: false),
                    CreateReport = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_Staj_StajIdId",
                        column: x => x.StajIdId,
                        principalTable: "Staj",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_SotrudnikIdId",
                table: "Comment",
                column: "SotrudnikIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_StajIdId",
                table: "Report",
                column: "StajIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Staj_SotrudnikIdId",
                table: "Staj",
                column: "SotrudnikIdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Staj");

            migrationBuilder.DropTable(
                name: "Sotrudnik");
        }
    }
}
