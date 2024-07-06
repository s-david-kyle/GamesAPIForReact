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
        modelBuilder.Entity<Genre>().HasData(GetSeedDataGenres());
        SeedGamePlatformRelationships(modelBuilder);
        SeedGameGenreRelationships(modelBuilder);
    }

    private static Genre[] GetSeedDataGenres()
    {
        return new Genre[]
        {
        new Genre { GenreId = 1, Name = "Action", Description = "Fast-paced games focusing on physical challenges and hand-eye coordination", slug = "action", ImageBackground = "https://cdn-icons-png.flaticon.com/32/1144/1144549.png" },
        new Genre { GenreId = 2, Name = "Adventure", Description = "Games emphasizing exploration, puzzle-solving, and narrative", slug = "adventure", ImageBackground = "https://cdn-icons-png.flaticon.com/32/2175/2175884.png" },
        new Genre { GenreId = 3, Name = "RPG", Description = "Games where players control characters in a fictional world, often with deep storytelling and character progression", slug = "rpg", ImageBackground = "https://cdn-icons-png.flaticon.com/32/3159/3159347.png" },
        new Genre { GenreId = 4, Name = "Strategy", Description = "Games that prioritize skillful thinking and planning to achieve victory", slug = "strategy", ImageBackground = "https://cdn-icons-png.flaticon.com/32/4204/4204638.png" },
        new Genre { GenreId = 5, Name = "Sports", Description = "Games simulating traditional physical sports and athletics", slug = "sports", ImageBackground = "https://cdn-icons-png.flaticon.com/32/857/857418.png" },
        new Genre { GenreId = 6, Name = "Simulation", Description = "Games designed to closely simulate real-world activities or systems", slug = "simulation", ImageBackground = "https://cdn-icons-png.flaticon.com/32/2780/2780137.png" },
        new Genre { GenreId = 7, Name = "Puzzle", Description = "Games that focus on logic and problem-solving", slug = "puzzle", ImageBackground = "https://cdn-icons-png.flaticon.com/32/3976/3976625.png" }
        };
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
        new Game { GameId = 1, Metacritic = 90, Name = "The Legend of Zelda: Breath of the Wild", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg/220px-The_Legend_of_Zelda_Breath_of_the_Wild.jpg", Released = new DateOnly(2017, 3, 3), Added = new DateOnly(2018, 5, 12), Created = new DateOnly(2017, 11, 23), Update = new DateOnly(2022, 8, 7), Rating = "E10+" },
        new Game { GameId = 2, Metacritic = 87, Name = "Red Dead Redemption 2", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Red_Dead_Redemption_II.jpg/220px-Red_Dead_Redemption_II.jpg", Released = new DateOnly(2018, 10, 26), Added = new DateOnly(2019, 2, 14), Created = new DateOnly(2018, 12, 1), Update = new DateOnly(2023, 3, 20), Rating = "M" },
        new Game { GameId = 3, Metacritic = 83, Name = "The Witcher 3: Wild Hunt", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Witcher_3_cover_art.jpg/220px-Witcher_3_cover_art.jpg", Released = new DateOnly(2015, 5, 19), Added = new DateOnly(2016, 7, 30), Created = new DateOnly(2015, 9, 5), Update = new DateOnly(2021, 11, 11), Rating = "M" },
        new Game { GameId = 4, Metacritic = 99, Name = "Grand Theft Auto V", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png", Released = new DateOnly(2013, 9, 17), Added = new DateOnly(2015, 3, 8), Created = new DateOnly(2014, 1, 22), Update = new DateOnly(2022, 6, 15), Rating = "M" },
        new Game { GameId = 5, Metacritic = 67, Name = "Bloodborne", Uri = "Bloodborne_Cover_Wallpaper.jpg", Released = new DateOnly(2015, 3, 24), Added = new DateOnly(2016, 9, 18), Created = new DateOnly(2015, 6, 7), Update = new DateOnly(2020, 12, 3), Rating = "M" },
        new Game { GameId = 6, Metacritic = 89, Name = "Dark Souls III", Uri = "https://image.api.playstation.com/cdn/UP0700/CUSA03388_00/v8JlD8KcQUtTqaLBmpFnj1ESRR5zMkLk.png", Released = new DateOnly(2016, 3, 24), Added = new DateOnly(2017, 5, 1), Created = new DateOnly(2016, 8, 14), Update = new DateOnly(2021, 7, 29), Rating = "M" },
        new Game { GameId = 7, Metacritic = 56, Name = "Super Mario Odyssey", Uri = "https://supermario.nintendo.com/assets/img/home/mario.png", Released = new DateOnly(2017, 10, 27), Added = new DateOnly(2018, 2, 9), Created = new DateOnly(2017, 12, 5), Update = new DateOnly(2022, 4, 18), Rating = "E10+" },
        new Game { GameId = 8, Metacritic = 98, Name = "God of War", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/God_of_War_4_cover.jpg/220px-God_of_War_4_cover.jpg", Released = new DateOnly(2018, 4, 20), Added = new DateOnly(2019, 1, 7), Created = new DateOnly(2018, 7, 3), Update = new DateOnly(2023, 2, 14), Rating = "M" },
        new Game { GameId = 9, Metacritic = 90, Name = "Persona 5", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8d/Persona_5_cover_art.jpg/220px-Persona_5_cover_art.jpg", Released = new DateOnly(2016, 9, 15), Added = new DateOnly(2017, 11, 22), Created = new DateOnly(2016, 12, 8), Update = new DateOnly(2021, 5, 30), Rating = "M" },
        new Game { GameId = 10, Metacritic = 76, Name = "Mass Effect 2", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e0/MassEffect2_cover.PNG/220px-MassEffect2_cover.PNG", Released = new DateOnly(2010, 1, 26), Added = new DateOnly(2015, 8, 19), Created = new DateOnly(2014, 4, 3), Update = new DateOnly(2020, 10, 12), Rating = "M" },
        new Game { GameId = 11, Metacritic = 77, Name = "Overwatch", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/Overwatch_cover_art.jpg/220px-Overwatch_cover_art.jpg", Released = new DateOnly(2016, 5, 24), Added = new DateOnly(2017, 3, 11), Created = new DateOnly(2016, 9, 27), Update = new DateOnly(2022, 1, 5), Rating = "T" },
        new Game { GameId = 12, Metacritic = 80, Name = "Fortnite", Uri = "https://cdn1.epicgames.com/offer/fn/FNBR_29-00_C5S2_EGS_Launcher_KeyArt_1200x1600_1200x1600-1f7675048d1b562fd66e93d7f89e791d.jpg", Released = new DateOnly(2017, 7, 25), Added = new DateOnly(2018, 10, 3), Created = new DateOnly(2017, 9, 14), Update = new DateOnly(2023, 4, 2), Rating = "T" },
        new Game { GameId = 13, Metacritic = 96, Name = "Minecraft", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/Minecraft_cover.png/220px-Minecraft_cover.png", Released = new DateOnly(2011, 11, 18), Added = new DateOnly(2015, 6, 25), Created = new DateOnly(2014, 2, 8), Update = new DateOnly(2022, 9, 17), Rating = "E10+" },
        new Game { GameId = 14, Metacritic = 56, Name = "Call of Duty: Modern Warfare", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a3/Call_of_Duty_Modern_Warfare.jpg/220px-Call_of_Duty_Modern_Warfare.jpg", Released = new DateOnly(2019, 10, 25), Added = new DateOnly(2020, 1, 9), Created = new DateOnly(2019, 11, 30), Update = new DateOnly(2023, 5, 8), Rating = "M" },
        new Game { GameId = 15, Metacritic = 96, Name = "Final Fantasy VII Remake", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/3/31/FFVIIRemake.png/220px-FFVIIRemake.png", Released = new DateOnly(2020, 4, 10), Added = new DateOnly(2020, 7, 22), Created = new DateOnly(2020, 5, 15), Update = new DateOnly(2023, 1, 3), Rating = "T" },
        new Game { GameId = 16, Metacritic = 97, Name = "Cyberpunk 2077", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Cyberpunk_2077_box_art.jpg/220px-Cyberpunk_2077_box_art.jpg", Released = new DateOnly(2020, 12, 10), Added = new DateOnly(2021, 2, 18), Created = new DateOnly(2020, 12, 28), Update = new DateOnly(2023, 6, 9), Rating = "M" },
        new Game { GameId = 17, Metacritic = 98, Name = "The Last of Us Part II", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/The_Last_of_Us_Part_II_cover_art.jpg/220px-The_Last_of_Us_Part_II_cover_art.jpg", Released = new DateOnly(2020, 6, 19), Added = new DateOnly(2020, 9, 5), Created = new DateOnly(2020, 7, 10), Update = new DateOnly(2022, 11, 25), Rating = "M" },
        new Game { GameId = 18, Metacritic = 95, Name = "Ghost of Tsushima", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Ghost_of_Tsushima.jpg/220px-Ghost_of_Tsushima.jpg", Released = new DateOnly(2020, 7, 17), Added = new DateOnly(2020, 10, 1), Created = new DateOnly(2020, 8, 9), Update = new DateOnly(2023, 3, 14), Rating = "M" },
        new Game { GameId = 19, Metacritic = 93, Name = "Hades", Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Hades_cover_art.jpg/220px-Hades_cover_art.jpg", Released = new DateOnly(2020, 9, 17), Added = new DateOnly(2020, 12, 3), Created = new DateOnly(2020, 10, 5), Update = new DateOnly(2022, 7, 19), Rating = "T" },
        new Game { GameId = 20, Metacritic = 92, Name = "Among Us", Uri = "https://steamcdn-a.akamaihd.net/steam/apps/945360/header.jpg?t=1603675313", Released = new DateOnly(2018, 6, 15), Added = new DateOnly(2020, 9, 28), Created = new DateOnly(2018, 8, 2), Update = new DateOnly(2023, 1, 17), Rating = "E" }
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

    private static void SeedGameGenreRelationships(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>()
            .HasMany(g => g.Genres)
            .WithMany(g => g.Games)
            .UsingEntity(j => j.HasData(
                // 1. The Legend of Zelda: Breath of the Wild
                new { GamesGameId = 1, GenresGenreId = 1 },
                new { GamesGameId = 1, GenresGenreId = 2 },

                // 2. Red Dead Redemption 2
                new { GamesGameId = 2, GenresGenreId = 1 },
                new { GamesGameId = 2, GenresGenreId = 2 },
                new { GamesGameId = 2, GenresGenreId = 3 },

                // 3. The Witcher 3: Wild Hunt
                new { GamesGameId = 3, GenresGenreId = 1 },
                new { GamesGameId = 3, GenresGenreId = 2 },
                new { GamesGameId = 3, GenresGenreId = 3 },

                // 4. Grand Theft Auto V
                new { GamesGameId = 4, GenresGenreId = 1 },
                new { GamesGameId = 4, GenresGenreId = 2 },

                // 5. Bloodborne
                new { GamesGameId = 5, GenresGenreId = 1 },
                new { GamesGameId = 5, GenresGenreId = 3 },

                // 6. Dark Souls III
                new { GamesGameId = 6, GenresGenreId = 1 },
                new { GamesGameId = 6, GenresGenreId = 3 },

                // 7. Super Mario Odyssey
                new { GamesGameId = 7, GenresGenreId = 1 },
                new { GamesGameId = 7, GenresGenreId = 2 },

                // 8. God of War
                new { GamesGameId = 8, GenresGenreId = 1 },
                new { GamesGameId = 8, GenresGenreId = 2 },

                // 9. Persona 5
                new { GamesGameId = 9, GenresGenreId = 3 },
                new { GamesGameId = 9, GenresGenreId = 4 },

                // 10. Mass Effect 2
                new { GamesGameId = 10, GenresGenreId = 1 },
                new { GamesGameId = 10, GenresGenreId = 3 },

                // 11. Overwatch
                new { GamesGameId = 11, GenresGenreId = 1 },
                new { GamesGameId = 11, GenresGenreId = 4 },

                // 12. Fortnite
                new { GamesGameId = 12, GenresGenreId = 1 },
                new { GamesGameId = 12, GenresGenreId = 4 },

                // 13. Minecraft
                new { GamesGameId = 13, GenresGenreId = 2 },
                new { GamesGameId = 13, GenresGenreId = 6 },

                // 14. Call of Duty: Modern Warfare
                new { GamesGameId = 14, GenresGenreId = 1 },
                new { GamesGameId = 14, GenresGenreId = 4 },

                // 15. Final Fantasy VII Remake
                new { GamesGameId = 15, GenresGenreId = 1 },
                new { GamesGameId = 15, GenresGenreId = 3 },

                // 16. Cyberpunk 2077
                new { GamesGameId = 16, GenresGenreId = 1 },
                new { GamesGameId = 16, GenresGenreId = 3 },

                // 17. The Last of Us Part II
                new { GamesGameId = 17, GenresGenreId = 1 },
                new { GamesGameId = 17, GenresGenreId = 2 },

                // 18. Ghost of Tsushima
                new { GamesGameId = 18, GenresGenreId = 1 },
                new { GamesGameId = 18, GenresGenreId = 2 },

                // 19. Hades
                new { GamesGameId = 19, GenresGenreId = 1 },
                new { GamesGameId = 19, GenresGenreId = 3 },

                // 20. Among Us
                new { GamesGameId = 20, GenresGenreId = 4 },
                new { GamesGameId = 20, GenresGenreId = 7 }
            ));
    }
}
