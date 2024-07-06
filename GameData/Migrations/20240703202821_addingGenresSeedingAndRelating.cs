using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameData.Migrations
{
    /// <inheritdoc />
    public partial class addingGenresSeedingAndRelating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "GameGenre",
                columns: table => new
                {
                    GamesGameId = table.Column<int>(type: "int", nullable: false),
                    GenresGenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenre", x => new { x.GamesGameId, x.GenresGenreId });
                    table.ForeignKey(
                        name: "FK_GameGenre_Games_GamesGameId",
                        column: x => x.GamesGameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGenre_Genre_GenresGenreId",
                        column: x => x.GenresGenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Description", "Name", "slug" },
                values: new object[,]
                {
                    { 1, "Fast-paced games focusing on physical challenges and hand-eye coordination", "Action", "action" },
                    { 2, "Games emphasizing exploration, puzzle-solving, and narrative", "Adventure", "adventure" },
                    { 3, "Games where players control characters in a fictional world, often with deep storytelling and character progression", "RPG", "rpg" },
                    { 4, "Games that prioritize skillful thinking and planning to achieve victory", "Strategy", "strategy" },
                    { 5, "Games simulating traditional physical sports and athletics", "Sports", "sports" },
                    { 6, "Games designed to closely simulate real-world activities or systems", "Simulation", "simulation" },
                    { 7, "Games that focus on logic and problem-solving", "Puzzle", "puzzle" }
                });

            migrationBuilder.InsertData(
                table: "GameGenre",
                columns: new[] { "GamesGameId", "GenresGenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 },
                    { 5, 1 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 3 },
                    { 7, 1 },
                    { 7, 2 },
                    { 8, 1 },
                    { 8, 2 },
                    { 9, 3 },
                    { 9, 4 },
                    { 10, 1 },
                    { 10, 3 },
                    { 11, 1 },
                    { 11, 4 },
                    { 12, 1 },
                    { 12, 4 },
                    { 13, 2 },
                    { 13, 6 },
                    { 14, 1 },
                    { 14, 4 },
                    { 15, 1 },
                    { 15, 3 },
                    { 16, 1 },
                    { 16, 3 },
                    { 17, 1 },
                    { 17, 2 },
                    { 18, 1 },
                    { 18, 2 },
                    { 19, 1 },
                    { 19, 3 },
                    { 20, 4 },
                    { 20, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameGenre_GenresGenreId",
                table: "GameGenre",
                column: "GenresGenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameGenre");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
