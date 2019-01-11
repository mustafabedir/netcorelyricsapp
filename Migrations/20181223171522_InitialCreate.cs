using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KoksHamit.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kullanicis",
                columns: table => new
                {
                    kullaniciID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    ad = table.Column<string>(nullable: true),
                    soyad = table.Column<string>(nullable: true),
                    mail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicis", x => x.kullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "sanatcis",
                columns: table => new
                {
                    sanatciID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sanatciAd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanatcis", x => x.sanatciID);
                });

            migrationBuilder.CreateTable(
                name: "yoneticis",
                columns: table => new
                {
                    adminID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yoneticis", x => x.adminID);
                });

            migrationBuilder.CreateTable(
                name: "muziks",
                columns: table => new
                {
                    muzikID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    muzikAd = table.Column<string>(nullable: true),
                    sozler = table.Column<string>(nullable: true),
                    sanatciID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_muziks", x => x.muzikID);
                    table.ForeignKey(
                        name: "FK_muziks_sanatcis_sanatciID",
                        column: x => x.sanatciID,
                        principalTable: "sanatcis",
                        principalColumn: "sanatciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "etikets",
                columns: table => new
                {
                    etiketID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    etiketAd = table.Column<string>(nullable: true),
                    muzikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_etikets", x => x.etiketID);
                    table.ForeignKey(
                        name: "FK_etikets_muziks_muzikID",
                        column: x => x.muzikID,
                        principalTable: "muziks",
                        principalColumn: "muzikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "yorums",
                columns: table => new
                {
                    yorumID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    icerik = table.Column<string>(nullable: true),
                    muzikID = table.Column<int>(nullable: false),
                    kullaniciID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yorums", x => x.yorumID);
                    table.ForeignKey(
                        name: "FK_yorums_kullanicis_kullaniciID",
                        column: x => x.kullaniciID,
                        principalTable: "kullanicis",
                        principalColumn: "kullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_yorums_muziks_muzikID",
                        column: x => x.muzikID,
                        principalTable: "muziks",
                        principalColumn: "muzikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_etikets_muzikID",
                table: "etikets",
                column: "muzikID");

            migrationBuilder.CreateIndex(
                name: "IX_muziks_sanatciID",
                table: "muziks",
                column: "sanatciID");

            migrationBuilder.CreateIndex(
                name: "IX_yorums_kullaniciID",
                table: "yorums",
                column: "kullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_yorums_muzikID",
                table: "yorums",
                column: "muzikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "etikets");

            migrationBuilder.DropTable(
                name: "yoneticis");

            migrationBuilder.DropTable(
                name: "yorums");

            migrationBuilder.DropTable(
                name: "kullanicis");

            migrationBuilder.DropTable(
                name: "muziks");

            migrationBuilder.DropTable(
                name: "sanatcis");
        }
    }
}
