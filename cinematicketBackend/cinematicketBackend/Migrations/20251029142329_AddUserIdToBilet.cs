using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cinematicketBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToBilet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Bilety",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_UserId",
                table: "Bilety",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilety_Users_UserId",
                table: "Bilety",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilety_Users_UserId",
                table: "Bilety");

            migrationBuilder.DropIndex(
                name: "IX_Bilety_UserId",
                table: "Bilety");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bilety");
        }
    }
}
