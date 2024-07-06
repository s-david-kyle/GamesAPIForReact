using GameDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData;

public partial class GamesContext : DbContext
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Platform> Platforms { get; set; }

    public GamesContext() : base()
    {

    }
    public GamesContext(DbContextOptions<GamesContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

            var connectionString = "Data Source=davaputer;Initial Catalog=GameDatabase;User ID=sa;Password=Alpha155;Trust Server Certificate=True";
            optionsBuilder
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information)
                .EnableSensitiveDataLogging();
        }
    }

}
