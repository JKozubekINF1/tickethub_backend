using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cinematicketBackend.Migrations
{
    /// <inheritdoc />
    public partial class biletyupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kupujacy",
                table: "Bilety");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kupujacy",
                table: "Bilety",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
