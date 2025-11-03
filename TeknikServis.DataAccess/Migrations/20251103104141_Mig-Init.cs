using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeknikServis.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MigInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cihazlar",
                columns: table => new
                {
                    CihazId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cihazlar", x => x.CihazId);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    MusteriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.MusteriId);
                });

            migrationBuilder.CreateTable(
                name: "ArizaKayitlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    CihazId = table.Column<int>(type: "int", nullable: false),
                    ArizaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArizaKayitlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArizaKayitlari_Cihazlar_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihazlar",
                        principalColumn: "CihazId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArizaKayitlari_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "MusteriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArizaKayitlari_CihazId",
                table: "ArizaKayitlari",
                column: "CihazId");

            migrationBuilder.CreateIndex(
                name: "IX_ArizaKayitlari_MusteriId",
                table: "ArizaKayitlari",
                column: "MusteriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArizaKayitlari");

            migrationBuilder.DropTable(
                name: "Cihazlar");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
