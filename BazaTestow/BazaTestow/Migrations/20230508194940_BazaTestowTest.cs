using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BazaTestow.Migrations
{
    /// <inheritdoc />
    public partial class BazaTestowTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nauczyciele",
                columns: table => new
                {
                    IDnauczyciela = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    WychowawcaKlasy = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Miejscowosc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ulica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumerDomu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    KodPocztowy = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nauczyciele", x => x.IDnauczyciela);
                });

            migrationBuilder.CreateTable(
                name: "Przedmioty",
                columns: table => new
                {
                    IDprzedmiotu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaPrzedmiotu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OpisPrzedmiotu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przedmioty", x => x.IDprzedmiotu);
                });

            migrationBuilder.CreateTable(
                name: "Uczniowie",
                columns: table => new
                {
                    IDucznia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Klasa = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Miejscowosc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ulica = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NumerDomu = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    KodPocztowy = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uczniowie", x => x.IDucznia);
                });

            migrationBuilder.CreateTable(
                name: "PrzedmiotNauczyciel",
                columns: table => new
                {
                    IDprzedmiotu = table.Column<int>(type: "int", nullable: false),
                    IDnauczyciela = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrzedmiotNauczyciel", x => new { x.IDprzedmiotu, x.IDnauczyciela });
                    table.ForeignKey(
                        name: "FK_PrzedmiotNauczyciel_Nauczyciele_IDnauczyciela",
                        column: x => x.IDnauczyciela,
                        principalTable: "Nauczyciele",
                        principalColumn: "IDnauczyciela",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrzedmiotNauczyciel_Przedmioty_IDprzedmiotu",
                        column: x => x.IDprzedmiotu,
                        principalTable: "Przedmioty",
                        principalColumn: "IDprzedmiotu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testy",
                columns: table => new
                {
                    IDtestu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDprzedmiotu = table.Column<int>(type: "int", nullable: false),
                    NazwaTestu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CzasTrwania = table.Column<TimeSpan>(type: "time", nullable: true),
                    LiczbaPytan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testy", x => x.IDtestu);
                    table.ForeignKey(
                        name: "FK_Testy_Przedmioty_IDprzedmiotu",
                        column: x => x.IDprzedmiotu,
                        principalTable: "Przedmioty",
                        principalColumn: "IDprzedmiotu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pytania",
                columns: table => new
                {
                    IDpytania = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDtestu = table.Column<int>(type: "int", nullable: false),
                    TrescPytania = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OpcjeOdpowiedzi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RodzajPytania = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MaksymalnaIloscPunktow = table.Column<float>(type: "real", nullable: true),
                    PrawidlowaOdpowiedz = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pytania", x => x.IDpytania);
                    table.ForeignKey(
                        name: "FK_Pytania_Testy_IDtestu",
                        column: x => x.IDtestu,
                        principalTable: "Testy",
                        principalColumn: "IDtestu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wyniki",
                columns: table => new
                {
                    IDtestu = table.Column<int>(type: "int", nullable: false),
                    IDucznia = table.Column<int>(type: "int", nullable: false),
                    IDwyniku = table.Column<int>(type: "int", nullable: false),
                    WynikPunktowy = table.Column<int>(type: "int", nullable: false),
                    DataUzyskania = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wyniki", x => new { x.IDucznia, x.IDtestu });
                    table.ForeignKey(
                        name: "FK_Wyniki_Testy_IDtestu",
                        column: x => x.IDtestu,
                        principalTable: "Testy",
                        principalColumn: "IDtestu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wyniki_Uczniowie_IDucznia",
                        column: x => x.IDucznia,
                        principalTable: "Uczniowie",
                        principalColumn: "IDucznia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Odpowiedzi",
                columns: table => new
                {
                    IDodpowiedzi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDpytania = table.Column<int>(type: "int", nullable: false),
                    IDucznia = table.Column<int>(type: "int", nullable: false),
                    OdpowiedzUcznia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzasUdzielaniaOdpowiedzi = table.Column<TimeSpan>(type: "time", nullable: true),
                    IloscPunktow = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odpowiedzi", x => x.IDodpowiedzi);
                    table.ForeignKey(
                        name: "FK_Odpowiedzi_Pytania_IDpytania",
                        column: x => x.IDpytania,
                        principalTable: "Pytania",
                        principalColumn: "IDpytania",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Odpowiedzi_Uczniowie_IDucznia",
                        column: x => x.IDucznia,
                        principalTable: "Uczniowie",
                        principalColumn: "IDucznia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Odpowiedzi_IDpytania",
                table: "Odpowiedzi",
                column: "IDpytania");

            migrationBuilder.CreateIndex(
                name: "IX_Odpowiedzi_IDucznia",
                table: "Odpowiedzi",
                column: "IDucznia");

            migrationBuilder.CreateIndex(
                name: "IX_PrzedmiotNauczyciel_IDnauczyciela",
                table: "PrzedmiotNauczyciel",
                column: "IDnauczyciela");

            migrationBuilder.CreateIndex(
                name: "IX_Pytania_IDtestu",
                table: "Pytania",
                column: "IDtestu");

            migrationBuilder.CreateIndex(
                name: "IX_Testy_IDprzedmiotu",
                table: "Testy",
                column: "IDprzedmiotu");

            migrationBuilder.CreateIndex(
                name: "IX_Wyniki_IDtestu",
                table: "Wyniki",
                column: "IDtestu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Odpowiedzi");

            migrationBuilder.DropTable(
                name: "PrzedmiotNauczyciel");

            migrationBuilder.DropTable(
                name: "Wyniki");

            migrationBuilder.DropTable(
                name: "Pytania");

            migrationBuilder.DropTable(
                name: "Nauczyciele");

            migrationBuilder.DropTable(
                name: "Uczniowie");

            migrationBuilder.DropTable(
                name: "Testy");

            migrationBuilder.DropTable(
                name: "Przedmioty");
        }
    }
}
