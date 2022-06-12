using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eOrdinacija.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osoba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UlogaUsistemu = table.Column<int>(type: "int", nullable: false),
                    datumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    spol = table.Column<int>(type: "int", nullable: false),
                    specijalizacija = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osoba", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usluga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usluga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacijent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Biljeska = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OsobaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacijent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacijent_Osoba_Id",
                        column: x => x.Id,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacijent_Osoba_OsobaId",
                        column: x => x.OsobaId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UposlenikUsluga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikId = table.Column<int>(type: "int", nullable: true),
                    UslugaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UposlenikUsluga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UposlenikUsluga_Osoba_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UposlenikUsluga_Usluga_UslugaId",
                        column: x => x.UslugaId,
                        principalTable: "Usluga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Karton",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacijentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karton", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Karton_Pacijent_PacijentId",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dijagnoza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datumUspostave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Terapija = table.Column<bool>(type: "bit", nullable: false),
                    KartonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dijagnoza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dijagnoza_Karton_KartonId",
                        column: x => x.KartonId,
                        principalTable: "Karton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KartonUposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikId = table.Column<int>(type: "int", nullable: true),
                    KartonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KartonUposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KartonUposlenik_Karton_KartonId",
                        column: x => x.KartonId,
                        principalTable: "Karton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KartonUposlenik_Osoba_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Osoba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nalaz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumVrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: true),
                    QrCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KartonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nalaz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nalaz_Karton_KartonId",
                        column: x => x.KartonId,
                        principalTable: "Karton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nalaz_Pacijent_PacijentId",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dijagnoza_KartonId",
                table: "Dijagnoza",
                column: "KartonId");

            migrationBuilder.CreateIndex(
                name: "IX_Karton_PacijentId",
                table: "Karton",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_KartonUposlenik_KartonId",
                table: "KartonUposlenik",
                column: "KartonId");

            migrationBuilder.CreateIndex(
                name: "IX_KartonUposlenik_UposlenikId",
                table: "KartonUposlenik",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Nalaz_KartonId",
                table: "Nalaz",
                column: "KartonId");

            migrationBuilder.CreateIndex(
                name: "IX_Nalaz_PacijentId",
                table: "Nalaz",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacijent_OsobaId",
                table: "Pacijent",
                column: "OsobaId");

            migrationBuilder.CreateIndex(
                name: "IX_UposlenikUsluga_UposlenikId",
                table: "UposlenikUsluga",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_UposlenikUsluga_UslugaId",
                table: "UposlenikUsluga",
                column: "UslugaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dijagnoza");

            migrationBuilder.DropTable(
                name: "KartonUposlenik");

            migrationBuilder.DropTable(
                name: "Nalaz");

            migrationBuilder.DropTable(
                name: "UposlenikUsluga");

            migrationBuilder.DropTable(
                name: "Karton");

            migrationBuilder.DropTable(
                name: "Usluga");

            migrationBuilder.DropTable(
                name: "Pacijent");

            migrationBuilder.DropTable(
                name: "Osoba");
        }
    }
}
