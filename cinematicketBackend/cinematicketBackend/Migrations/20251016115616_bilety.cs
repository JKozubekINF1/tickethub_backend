using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cinematicketBackend.Migrations
{
    /// <inheritdoc />
    public partial class bilety : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilety",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeansId = table.Column<int>(type: "int", nullable: false),
                    NumerMiejsca = table.Column<int>(type: "int", nullable: false),
                    Kupujacy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilety", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bilety_Seanse_SeansId",
                        column: x => x.SeansId,
                        principalTable: "Seanse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_SeansId",
                table: "Bilety",
                column: "SeansId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilety");
        }
    }
}
