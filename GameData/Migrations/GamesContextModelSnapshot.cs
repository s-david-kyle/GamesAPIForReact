﻿// <auto-generated />
using GameData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameData.Migrations
{
    [DbContext(typeof(GamesContext))]
    partial class GamesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameDomain.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            Name = "The Legend of Zelda: Breath of the Wild",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg/220px-The_Legend_of_Zelda_Breath_of_the_Wild.jpg"
                        },
                        new
                        {
                            GameId = 2,
                            Name = "Red Dead Redemption 2",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Red_Dead_Redemption_II.jpg/220px-Red_Dead_Redemption_II.jpg"
                        },
                        new
                        {
                            GameId = 3,
                            Name = "The Witcher 3: Wild Hunt",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Witcher_3_cover_art.jpg/220px-Witcher_3_cover_art.jpg"
                        },
                        new
                        {
                            GameId = 4,
                            Name = "Grand Theft Auto V",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png"
                        },
                        new
                        {
                            GameId = 5,
                            Name = "Bloodborne",
                            Uri = "Bloodborne_Cover_Wallpaper.jpg"
                        },
                        new
                        {
                            GameId = 6,
                            Name = "Dark Souls III",
                            Uri = "https://image.api.playstation.com/cdn/UP0700/CUSA03388_00/v8JlD8KcQUtTqaLBmpFnj1ESRR5zMkLk.png"
                        },
                        new
                        {
                            GameId = 7,
                            Name = "Super Mario Odyssey",
                            Uri = "https://supermario.nintendo.com/assets/img/home/mario.png"
                        },
                        new
                        {
                            GameId = 8,
                            Name = "God of War",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/God_of_War_4_cover.jpg/220px-God_of_War_4_cover.jpg"
                        },
                        new
                        {
                            GameId = 9,
                            Name = "Persona 5",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8d/Persona_5_cover_art.jpg/220px-Persona_5_cover_art.jpg"
                        },
                        new
                        {
                            GameId = 10,
                            Name = "Mass Effect 2",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e0/MassEffect2_cover.PNG/220px-MassEffect2_cover.PNG"
                        },
                        new
                        {
                            GameId = 11,
                            Name = "Overwatch",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/Overwatch_cover_art.jpg/220px-Overwatch_cover_art.jpg"
                        },
                        new
                        {
                            GameId = 12,
                            Name = "Fortnite",
                            Uri = "https://cdn1.epicgames.com/offer/fn/FNBR_29-00_C5S2_EGS_Launcher_KeyArt_1200x1600_1200x1600-1f7675048d1b562fd66e93d7f89e791d.jpg"
                        },
                        new
                        {
                            GameId = 13,
                            Name = "Minecraft",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/5/51/Minecraft_cover.png/220px-Minecraft_cover.png"
                        },
                        new
                        {
                            GameId = 14,
                            Name = "Call of Duty: Modern Warfare",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a3/Call_of_Duty_Modern_Warfare.jpg/220px-Call_of_Duty_Modern_Warfare.jpg"
                        },
                        new
                        {
                            GameId = 15,
                            Name = "Final Fantasy VII Remake",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/3/31/FFVIIRemake.png/220px-FFVIIRemake.png"
                        },
                        new
                        {
                            GameId = 16,
                            Name = "Cyberpunk 2077",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Cyberpunk_2077_box_art.jpg/220px-Cyberpunk_2077_box_art.jpg"
                        },
                        new
                        {
                            GameId = 17,
                            Name = "The Last of Us Part II",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/The_Last_of_Us_Part_II_cover_art.jpg/220px-The_Last_of_Us_Part_II_cover_art.jpg"
                        },
                        new
                        {
                            GameId = 18,
                            Name = "Ghost of Tsushima",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Ghost_of_Tsushima.jpg/220px-Ghost_of_Tsushima.jpg"
                        },
                        new
                        {
                            GameId = 19,
                            Name = "Hades",
                            Uri = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Hades_cover_art.jpg/220px-Hades_cover_art.jpg"
                        },
                        new
                        {
                            GameId = 20,
                            Name = "Among Us",
                            Uri = "https://steamcdn-a.akamaihd.net/steam/apps/945360/header.jpg?t=1603675313"
                        });
                });

            modelBuilder.Entity("GameDomain.Platform", b =>
                {
                    b.Property<int>("PlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlatformId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlatformId");

                    b.ToTable("Platform");

                    b.HasData(
                        new
                        {
                            PlatformId = 1,
                            Name = "Nintendo Switch",
                            Slug = "nintendo-switch"
                        },
                        new
                        {
                            PlatformId = 2,
                            Name = "PlayStation 4",
                            Slug = "playstation-4"
                        },
                        new
                        {
                            PlatformId = 3,
                            Name = "Xbox One",
                            Slug = "xbox-one"
                        },
                        new
                        {
                            PlatformId = 4,
                            Name = "PC",
                            Slug = "pc"
                        });
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.Property<int>("GamesGameId")
                        .HasColumnType("int");

                    b.Property<int>("PlatformsPlatformId")
                        .HasColumnType("int");

                    b.HasKey("GamesGameId", "PlatformsPlatformId");

                    b.HasIndex("PlatformsPlatformId");

                    b.ToTable("GamePlatform");

                    b.HasData(
                        new
                        {
                            GamesGameId = 1,
                            PlatformsPlatformId = 1
                        },
                        new
                        {
                            GamesGameId = 2,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 2,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 2,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 3,
                            PlatformsPlatformId = 1
                        },
                        new
                        {
                            GamesGameId = 3,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 3,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 3,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 4,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 4,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 4,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 5,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 6,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 6,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 6,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 7,
                            PlatformsPlatformId = 1
                        },
                        new
                        {
                            GamesGameId = 8,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 8,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 9,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 9,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 9,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 10,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 10,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 10,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 11,
                            PlatformsPlatformId = 1
                        },
                        new
                        {
                            GamesGameId = 11,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 11,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 11,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 12,
                            PlatformsPlatformId = 1
                        },
                        new
                        {
                            GamesGameId = 12,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 12,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 12,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 13,
                            PlatformsPlatformId = 1
                        },
                        new
                        {
                            GamesGameId = 13,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 13,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 13,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 14,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 14,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 14,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 15,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 15,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 16,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 16,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 16,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 17,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 18,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 19,
                            PlatformsPlatformId = 1
                        },
                        new
                        {
                            GamesGameId = 19,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 19,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 19,
                            PlatformsPlatformId = 4
                        },
                        new
                        {
                            GamesGameId = 20,
                            PlatformsPlatformId = 1
                        },
                        new
                        {
                            GamesGameId = 20,
                            PlatformsPlatformId = 2
                        },
                        new
                        {
                            GamesGameId = 20,
                            PlatformsPlatformId = 3
                        },
                        new
                        {
                            GamesGameId = 20,
                            PlatformsPlatformId = 4
                        });
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.HasOne("GameDomain.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameDomain.Platform", null)
                        .WithMany()
                        .HasForeignKey("PlatformsPlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}