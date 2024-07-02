using GameDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData;

public partial class GamesContext : DbContext
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasData(GetSeedDataGames());
        modelBuilder.Entity<Platform>().HasData(GetSeedDataPlatforms());
        SeedGamePlatformRelationships(modelBuilder);
    }

    private static Platform[] GetSeedDataPlatforms()
    {
        return new Platform[]
        {
            new Platform { PlatformId = 1, Name = "Nintendo Switch", Slug = "nintendo-switch" },
            new Platform { PlatformId = 2, Name = "PlayStation 4", Slug = "playstation-4" },
            new Platform { PlatformId = 3, Name = "Xbox One", Slug = "xbox-one" },
            new Platform { PlatformId = 4, Name = "PC", Slug = "pc" }
        };
    }

    private static Game[] GetSeedDataGames()
    {
        return new Game[]
        {
            new Game { GameId = 1, Name = "The Legend of Zelda: Breath of the Wild", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg/220px-The_Legend_of_Zelda_Breath_of_the_Wild.jpg" },
            new Game { GameId = 2, Name = "Red Dead Redemption 2", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Red_Dead_Redemption_II.jpg/220px-Red_Dead_Redemption_II.jpg" },
            new Game { GameId = 3, Name = "The Witcher 3: Wild Hunt", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Witcher_3_cover_art.jpg/220px-Witcher_3_cover_art.jpg" },
            new Game { GameId = 4, Name = "Grand Theft Auto V", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png" },
            new Game { GameId = 5, Name = "Bloodborne", Uri = "Bloodborne_Cover_Wallpaper.jpg" },
            new Game { GameId = 6, Name = "Dark Souls III", Uri = "https://image.api.playstation.com/cdn/UP0700/CUSA03388_00/v8JlD8KcQUtTqaLBmpFnj1ESRR5zMkLk.png" },
            new Game { GameId = 7, Name = "Super Mario Odyssey", Uri = "https://supermario.nintendo.com/assets/img/home/mario.png" },
            new Game { GameId = 8, Name = "God of War", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/God_of_War_4_cover.jpg/220px-God_of_War_4_cover.jpg" },
            new Game { GameId = 9, Name = "Persona 5", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8d/Persona_5_cover_art.jpg/220px-Persona_5_cover_art.jpg" },
            new Game { GameId = 10, Name = "Mass Effect 2", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e0/MassEffect2_cover.PNG/220px-MassEffect2_cover.PNG" },
            new Game { GameId = 11, Name = "Overwatch", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/Overwatch_cover_art.jpg/220px-Overwatch_cover_art.jpg" },
            new Game { GameId = 12, Name = "Fortnite", Uri = "https://cdn1.epicgames.com/offer/fn/FNBR_29-00_C5S2_EGS_Launcher_KeyArt_1200x1600_1200x1600-1f7675048d1b562fd66e93d7f89e791d.jpg" },
            new Game { GameId = 13, Name = "Minecraft", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/Minecraft_cover.png/220px-Minecraft_cover.png" },
            new Game { GameId = 14, Name = "Call of Duty: Modern Warfare", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a3/Call_of_Duty_Modern_Warfare.jpg/220px-Call_of_Duty_Modern_Warfare.jpg" },
            new Game { GameId = 15, Name = "Final Fantasy VII Remake", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/3/31/FFVIIRemake.png/220px-FFVIIRemake.png" },
            new Game { GameId = 16, Name = "Cyberpunk 2077", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Cyberpunk_2077_box_art.jpg/220px-Cyberpunk_2077_box_art.jpg" },
            new Game { GameId = 17, Name = "The Last of Us Part II", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/The_Last_of_Us_Part_II_cover_art.jpg/220px-The_Last_of_Us_Part_II_cover_art.jpg" },
            new Game { GameId = 18, Name = "Ghost of Tsushima", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Ghost_of_Tsushima.jpg/220px-Ghost_of_Tsushima.jpg" },
            new Game { GameId = 19, Name = "Hades", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Hades_cover_art.jpg/220px-Hades_cover_art.jpg" },
            new Game { GameId = 20, Name = "Among Us", Uri = "https://steamcdn-a.akamaihd.net/steam/apps/945360/header.jpg?t=1603675313" }
        };
    }


    private static void SeedGamePlatformRelationships(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>()
            .HasMany(g => g.Platforms)
            .WithMany(p => p.Games)
            .UsingEntity(j => j.HasData(
                // 1. The Legend of Zelda: Breath of the Wild
                new { GamesGameId = 1, PlatformsPlatformId = 1 },

                // 2. Red Dead Redemption 2
                new { GamesGameId = 2, PlatformsPlatformId = 2 },
                new { GamesGameId = 2, PlatformsPlatformId = 3 },
                new { GamesGameId = 2, PlatformsPlatformId = 4 },

                // 3. The Witcher 3: Wild Hunt
                new { GamesGameId = 3, PlatformsPlatformId = 1 },
                new { GamesGameId = 3, PlatformsPlatformId = 2 },
                new { GamesGameId = 3, PlatformsPlatformId = 3 },
                new { GamesGameId = 3, PlatformsPlatformId = 4 },

                // 4. Grand Theft Auto V
                new { GamesGameId = 4, PlatformsPlatformId = 2 },
                new { GamesGameId = 4, PlatformsPlatformId = 3 },
                new { GamesGameId = 4, PlatformsPlatformId = 4 },

                // 5. Bloodborne
                new { GamesGameId = 5, PlatformsPlatformId = 2 },

                // 6. Dark Souls III
                new { GamesGameId = 6, PlatformsPlatformId = 2 },
                new { GamesGameId = 6, PlatformsPlatformId = 3 },
                new { GamesGameId = 6, PlatformsPlatformId = 4 },

                // 7. Super Mario Odyssey
                new { GamesGameId = 7, PlatformsPlatformId = 1 },

                // 8. God of War
                new { GamesGameId = 8, PlatformsPlatformId = 2 },
                new { GamesGameId = 8, PlatformsPlatformId = 4 },

                // 9. Persona 5
                new { GamesGameId = 9, PlatformsPlatformId = 2 },
                new { GamesGameId = 9, PlatformsPlatformId = 3 },
                new { GamesGameId = 9, PlatformsPlatformId = 4 },

                // 10. Mass Effect 2
                new { GamesGameId = 10, PlatformsPlatformId = 2 },
                new { GamesGameId = 10, PlatformsPlatformId = 3 },
                new { GamesGameId = 10, PlatformsPlatformId = 4 },

                // 11. Overwatch
                new { GamesGameId = 11, PlatformsPlatformId = 1 },
                new { GamesGameId = 11, PlatformsPlatformId = 2 },
                new { GamesGameId = 11, PlatformsPlatformId = 3 },
                new { GamesGameId = 11, PlatformsPlatformId = 4 },

                // 12. Fortnite
                new { GamesGameId = 12, PlatformsPlatformId = 1 },
                new { GamesGameId = 12, PlatformsPlatformId = 2 },
                new { GamesGameId = 12, PlatformsPlatformId = 3 },
                new { GamesGameId = 12, PlatformsPlatformId = 4 },

                // 13. Minecraft
                new { GamesGameId = 13, PlatformsPlatformId = 1 },
                new { GamesGameId = 13, PlatformsPlatformId = 2 },
                new { GamesGameId = 13, PlatformsPlatformId = 3 },
                new { GamesGameId = 13, PlatformsPlatformId = 4 },

                // 14. Call of Duty: Modern Warfare
                new { GamesGameId = 14, PlatformsPlatformId = 2 },
                new { GamesGameId = 14, PlatformsPlatformId = 3 },
                new { GamesGameId = 14, PlatformsPlatformId = 4 },

                // 15. Final Fantasy VII Remake
                new { GamesGameId = 15, PlatformsPlatformId = 2 },
                new { GamesGameId = 15, PlatformsPlatformId = 4 },

                // 16. Cyberpunk 2077
                new { GamesGameId = 16, PlatformsPlatformId = 2 },
                new { GamesGameId = 16, PlatformsPlatformId = 3 },
                new { GamesGameId = 16, PlatformsPlatformId = 4 },

                // 17. The Last of Us Part II
                new { GamesGameId = 17, PlatformsPlatformId = 2 },

                // 18. Ghost of Tsushima
                new { GamesGameId = 18, PlatformsPlatformId = 2 },

                // 19. Hades
                new { GamesGameId = 19, PlatformsPlatformId = 1 },
                new { GamesGameId = 19, PlatformsPlatformId = 2 },
                new { GamesGameId = 19, PlatformsPlatformId = 3 },
                new { GamesGameId = 19, PlatformsPlatformId = 4 },

                // 20. Among Us
                new { GamesGameId = 20, PlatformsPlatformId = 1 },
                new { GamesGameId = 20, PlatformsPlatformId = 2 },
                new { GamesGameId = 20, PlatformsPlatformId = 3 },
                new { GamesGameId = 20, PlatformsPlatformId = 4 }
            ));
    }
}
