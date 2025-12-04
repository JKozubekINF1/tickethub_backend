using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cinematicketBackend.Migrations
{
    /// <inheritdoc />
    public partial class updateseanse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Miejscowosc",
                table: "Seanse",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Seanse",
                columns: new[] { "Id", "Data", "Gatunek", "Godzina", "Miejscowosc", "TypSeansu", "Tytul", "WiekMin" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:30", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 2, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:30", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 3, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:15", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 4, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:00", "Lubin", "Dubbing", "Vaiana 2", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<int>(
                name: "Miejscowosc",
                table: "Seanse",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
