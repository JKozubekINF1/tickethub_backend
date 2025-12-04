using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cinematicketBackend.Migrations
{
    /// <inheritdoc />
    public partial class seansemore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 3,
                column: "Miejscowosc",
                value: "Legnica");

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 4,
                column: "Miejscowosc",
                value: "Legnica");

            migrationBuilder.InsertData(
                table: "Seanse",
                columns: new[] { "Id", "Data", "Gatunek", "Godzina", "Miejscowosc", "TypSeansu", "Tytul", "WiekMin" },
                values: new object[,]
                {
                    { 5, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:00", "Legnica", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 6, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 7, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 8, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:30", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 9, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:00", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 10, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "20:30", "Lubin", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 11, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:30", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 12, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "19:30", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 13, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:00", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 14, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:30", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 15, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:00", "Wrocław (Aleja Bielany)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 16, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:00", "Wrocław (Aleja Bielany)", "Napisy", "Gladiator 2", 15 },
                    { 17, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:15", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 18, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:15", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 19, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:00", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 20, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:30", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 21, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:15", "Wrocław (Magnolia Park)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 22, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "19:00", "Wrocław (Magnolia Park)", "Napisy", "Gladiator 2", 15 },
                    { 23, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:30", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 24, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:30", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 25, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:15", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 26, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:00", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 27, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:00", "Legnica", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 28, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 29, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 30, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:30", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 31, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:00", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 32, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "20:30", "Lubin", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 33, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:30", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 34, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "19:30", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 35, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:00", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 36, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:30", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 37, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:00", "Wrocław (Aleja Bielany)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 38, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:00", "Wrocław (Aleja Bielany)", "Napisy", "Gladiator 2", 15 },
                    { 39, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:15", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 40, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:15", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 41, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:00", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 42, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:30", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 43, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:15", "Wrocław (Magnolia Park)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 44, new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "19:00", "Wrocław (Magnolia Park)", "Napisy", "Gladiator 2", 15 },
                    { 45, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:30", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 46, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:30", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 47, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:15", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 48, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:00", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 49, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:00", "Legnica", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 50, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 51, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 52, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:30", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 53, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:00", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 54, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "20:30", "Lubin", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 55, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:30", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 56, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "19:30", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 57, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:00", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 58, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:30", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 59, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:00", "Wrocław (Aleja Bielany)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 60, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:00", "Wrocław (Aleja Bielany)", "Napisy", "Gladiator 2", 15 },
                    { 61, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:15", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 62, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:15", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 63, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:00", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 64, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:30", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 65, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:15", "Wrocław (Magnolia Park)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 66, new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "19:00", "Wrocław (Magnolia Park)", "Napisy", "Gladiator 2", 15 },
                    { 67, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:30", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 68, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:30", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 69, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:15", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 70, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:00", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 71, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:00", "Legnica", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 72, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 73, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 74, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:30", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 75, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:00", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 76, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "20:30", "Lubin", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 77, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:30", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 78, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "19:30", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 79, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:00", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 80, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:30", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 81, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:00", "Wrocław (Aleja Bielany)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 82, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:00", "Wrocław (Aleja Bielany)", "Napisy", "Gladiator 2", 15 },
                    { 83, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:15", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 84, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:15", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 85, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:00", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 86, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "18:30", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 87, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "21:15", "Wrocław (Magnolia Park)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 88, new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "19:00", "Wrocław (Magnolia Park)", "Napisy", "Gladiator 2", 15 },
                    { 89, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:00", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 90, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "21:15", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 91, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:45", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 92, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:15", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 93, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:15", "Legnica", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 94, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "20:00", "Legnica", "Napisy", "Gladiator 2", 15 },
                    { 95, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:15", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 96, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "21:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 97, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:30", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 98, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:45", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 99, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:00", "Lubin", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 100, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "20:30", "Lubin", "Napisy", "Gladiator 2", 15 },
                    { 101, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:00", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 102, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "21:15", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 103, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:00", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 104, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:15", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 105, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:00", "Wrocław (Aleja Bielany)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 106, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:30", "Wrocław (Aleja Bielany)", "Napisy", "Gladiator 2", 15 },
                    { 107, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:45", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 108, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "21:30", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 109, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:00", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 110, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:15", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 111, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:30", "Wrocław (Magnolia Park)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 112, new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:45", "Wrocław (Magnolia Park)", "Napisy", "Gladiator 2", 15 },
                    { 113, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:00", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 114, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "21:15", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 115, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:45", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 116, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:15", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 117, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:15", "Legnica", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 118, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "20:00", "Legnica", "Napisy", "Gladiator 2", 15 },
                    { 119, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:15", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 120, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "21:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 121, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:30", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 122, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:45", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 123, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:00", "Lubin", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 124, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "20:30", "Lubin", "Napisy", "Gladiator 2", 15 },
                    { 125, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:00", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 126, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "21:15", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 127, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:00", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 128, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:15", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 129, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:00", "Wrocław (Aleja Bielany)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 130, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:30", "Wrocław (Aleja Bielany)", "Napisy", "Gladiator 2", 15 },
                    { 131, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:45", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 132, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "21:30", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 133, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:00", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 134, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:15", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 135, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:30", "Wrocław (Magnolia Park)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 136, new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:45", "Wrocław (Magnolia Park)", "Napisy", "Gladiator 2", 15 },
                    { 137, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:00", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 138, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:15", "Legnica", "Napisy", "Joker: Folie à Deux", 15 },
                    { 139, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:45", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 140, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:15", "Legnica", "Dubbing", "Vaiana 2", 0 },
                    { 141, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:30", "Legnica", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 142, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "19:45", "Legnica", "Napisy", "Gladiator 2", 15 },
                    { 143, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "17:15", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 144, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:00", "Lubin", "Napisy", "Joker: Folie à Deux", 15 },
                    { 145, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:30", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 146, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:45", "Lubin", "Dubbing", "Vaiana 2", 0 },
                    { 147, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:00", "Lubin", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 148, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "19:30", "Lubin", "Napisy", "Gladiator 2", 15 },
                    { 149, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:00", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 150, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:15", "Wrocław (Aleja Bielany)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 151, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "14:00", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 152, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "16:15", "Wrocław (Aleja Bielany)", "Dubbing", "Vaiana 2", 0 },
                    { 153, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "18:30", "Wrocław (Aleja Bielany)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 154, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:00", "Wrocław (Aleja Bielany)", "Napisy", "Gladiator 2", 15 },
                    { 155, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "16:45", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 156, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thriller / Musical", "20:30", "Wrocław (Magnolia Park)", "Napisy", "Joker: Folie à Deux", 15 },
                    { 157, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "15:00", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 158, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animacja / Przygodowy", "17:15", "Wrocław (Magnolia Park)", "Dubbing", "Vaiana 2", 0 },
                    { 159, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Komedia / Fantasy", "19:30", "Wrocław (Magnolia Park)", "Napisy", "Beetlejuice Beetlejuice", 13 },
                    { 160, new DateTime(2025, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akcja / Dramat", "18:15", "Wrocław (Magnolia Park)", "Napisy", "Gladiator 2", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 3,
                column: "Miejscowosc",
                value: "Lubin");

            migrationBuilder.UpdateData(
                table: "Seanse",
                keyColumn: "Id",
                keyValue: 4,
                column: "Miejscowosc",
                value: "Lubin");
        }
    }
}
