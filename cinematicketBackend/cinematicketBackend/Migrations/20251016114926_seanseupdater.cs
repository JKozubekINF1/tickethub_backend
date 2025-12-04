using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cinematicketBackend.Migrations
{
    /// <inheritdoc />
    public partial class seanseupdater : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Seanse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiczbaMiejsc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sale",
                columns: new[] { "Id", "LiczbaMiejsc", "Nazwa" },
                values: new object[,]
                {
                    { 1, 100, "Sala 1" },
                    { 2, 100, "Sala 2" },
                    { 3, 100, "Sala 3" }
                });

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 4,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 5,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 6,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 7,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 8,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 9,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 10,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 11,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 12,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 13,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 14,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 15,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 16,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 17,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 18,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 19,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 20,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 21,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 22,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 23,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 24,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 25,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 26,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 27,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 28,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 29,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 30,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 31,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 32,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 33,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 34,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 35,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 36,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 37,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 38,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 39,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 40,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 41,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 42,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 43,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 44,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 45,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 46,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 47,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 48,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 49,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 50,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 51,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 52,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 53,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 54,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 55,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 56,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 57,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 58,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 59,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 60,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 61,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 62,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 63,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 64,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 65,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 66,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 67,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 68,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 69,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 70,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 71,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 72,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 73,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 74,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 75,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 76,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 77,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 78,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 79,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 80,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 81,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 82,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 83,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 84,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 85,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 86,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 87,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 88,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 89,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 90,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 91,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 92,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 93,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 94,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 95,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 96,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 97,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 98,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 99,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 100,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 101,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 102,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 103,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 104,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 105,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 106,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 107,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 108,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 109,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 110,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 111,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 112,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 113,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 114,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 115,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 116,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 117,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 118,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 119,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 120,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 121,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 122,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 123,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 124,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 125,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 126,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 127,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 128,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 129,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 130,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 131,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 132,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 133,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 134,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 135,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 136,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 137,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 138,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 139,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 140,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 141,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 142,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 143,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 144,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 145,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 146,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 147,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 148,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 149,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 150,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 151,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 152,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 153,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 154,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 155,
                column: "SalaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 156,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 157,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 158,
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 159,
                column: "SalaId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 160,
                column: "SalaId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Seanse_SalaId",
                table: "Seanse",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seanse_Sale_SalaId",
                table: "Seanse",
                column: "SalaId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seanse_Sale_SalaId",
                table: "Seanse");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Seanse_SalaId",
                table: "Seanse");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Seanse");
        }
    }
}
