using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cinematicketBackend.Migrations
{
    /// <inheritdoc />
    public partial class DodanieKoduBiletu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KodBiletu",
                table: "Bilety",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KodBiletu",
                table: "Bilety");
        }
    }
}
