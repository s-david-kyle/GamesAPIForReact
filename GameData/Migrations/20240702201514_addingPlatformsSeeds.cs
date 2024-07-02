using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameData.Migrations
{
    /// <inheritdoc />
    public partial class addingPlatformsSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "GamePlatform",
                columns: table => new
                {
                    GamesGameId = table.Column<int>(type: "int", nullable: false),
                    PlatformsPlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlatform", x => new { x.GamesGameId, x.PlatformsPlatformId });
                    table.ForeignKey(
                        name: "FK_GamePlatform_Games_GamesGameId",
                        column: x => x.GamesGameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlatform_Platform_PlatformsPlatformId",
                        column: x => x.PlatformsPlatformId,
                        principalTable: "Platform",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "Uri" },
                values: new object[,]
                {
                    { 1, "The Legend of Zelda: Breath of the Wild", "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg/220px-The_Legend_of_Zelda_Breath_of_the_Wild.jpg" },
                    { 2, "Red Dead Redemption 2", "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Red_Dead_Redemption_II.jpg/220px-Red_Dead_Redemption_II.jpg" },
                    { 3, "The Witcher 3: Wild Hunt", "https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Witcher_3_cover_art.jpg/220px-Witcher_3_cover_art.jpg" },
                    { 4, "Grand Theft Auto V", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png" },
                    { 5, "Bloodborne", "Bloodborne_Cover_Wallpaper.jpg" },
                    { 6, "Dark Souls III", "https://image.api.playstation.com/cdn/UP0700/CUSA03388_00/v8JlD8KcQUtTqaLBmpFnj1ESRR5zMkLk.png" },
                    { 7, "Super Mario Odyssey", "https://supermario.nintendo.com/assets/img/home/mario.png" },
                    { 8, "God of War", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/God_of_War_4_cover.jpg/220px-God_of_War_4_cover.jpg" },
                    { 9, "Persona 5", "https://upload.wikimedia.org/wikipedia/en/thumb/8/8d/Persona_5_cover_art.jpg/220px-Persona_5_cover_art.jpg" },
                    { 10, "Mass Effect 2", "https://upload.wikimedia.org/wikipedia/en/thumb/e/e0/MassEffect2_cover.PNG/220px-MassEffect2_cover.PNG" },
                    { 11, "Overwatch", "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/Overwatch_cover_art.jpg/220px-Overwatch_cover_art.jpg" },
                    { 12, "Fortnite", "https://cdn1.epicgames.com/offer/fn/FNBR_29-00_C5S2_EGS_Launcher_KeyArt_1200x1600_1200x1600-1f7675048d1b562fd66e93d7f89e791d.jpg" },
                    { 13, "Minecraft", "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/Minecraft_cover.png/220px-Minecraft_cover.png" },
                    { 14, "Call of Duty: Modern Warfare", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a3/Call_of_Duty_Modern_Warfare.jpg/220px-Call_of_Duty_Modern_Warfare.jpg" },
                    { 15, "Final Fantasy VII Remake", "https://upload.wikimedia.org/wikipedia/en/thumb/3/31/FFVIIRemake.png/220px-FFVIIRemake.png" },
                    { 16, "Cyberpunk 2077", "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Cyberpunk_2077_box_art.jpg/220px-Cyberpunk_2077_box_art.jpg" },
                    { 17, "The Last of Us Part II", "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/The_Last_of_Us_Part_II_cover_art.jpg/220px-The_Last_of_Us_Part_II_cover_art.jpg" },
                    { 18, "Ghost of Tsushima", "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Ghost_of_Tsushima.jpg/220px-Ghost_of_Tsushima.jpg" },
                    { 19, "Hades", "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Hades_cover_art.jpg/220px-Hades_cover_art.jpg" },
                    { 20, "Among Us", "https://steamcdn-a.akamaihd.net/steam/apps/945360/header.jpg?t=1603675313" }
                });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "PlatformId", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "Nintendo Switch", "nintendo-switch" },
                    { 2, "PlayStation 4", "playstation-4" },
                    { 3, "Xbox One", "xbox-one" },
                    { 4, "PC", "pc" }
                });

            migrationBuilder.InsertData(
                table: "GamePlatform",
                columns: new[] { "GamesGameId", "PlatformsPlatformId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 2 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 7, 1 },
                    { 8, 2 },
                    { 8, 4 },
                    { 9, 2 },
                    { 9, 3 },
                    { 9, 4 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 11, 4 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 12, 4 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 13, 4 },
                    { 14, 2 },
                    { 14, 3 },
                    { 14, 4 },
                    { 15, 2 },
                    { 15, 4 },
                    { 16, 2 },
                    { 16, 3 },
                    { 16, 4 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 1 },
                    { 19, 2 },
                    { 19, 3 },
                    { 19, 4 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 },
                    { 20, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GamePlatform_PlatformsPlatformId",
                table: "GamePlatform",
                column: "PlatformsPlatformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GamePlatform");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 20);
        }
    }
}
