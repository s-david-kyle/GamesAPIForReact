using Microsoft.EntityFrameworkCore;
using GameData;
using GameDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Mvc;

namespace Games;

public static class GameEndpoints
{
    public static void MapGameEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Game").WithTags(nameof(Game));

        group.MapGet("/", async (GamesContext db) =>
        {
            return await db.Games.ToListAsync();
        })
        .WithName("GetAllGames")
        .WithOpenApi();

        group.MapGet("/GetGamesWithCount", async (GameService gameService, [FromQuery] string? genres = null, int? platforms = null, string? ordering = null, string? search = null) =>
        {
            var (results, count) = await gameService.GetGamesWithCount(genres, platforms, ordering, search);

            return new
            {
                Results = results,
                Count = count
            };
        })
        .WithName("GetGamesWithCount")
        .WithOpenApi();


        #region oldCode
        //group.MapGet("/GetGamesWithCount", async (GamesContext db, [FromQuery] string? genres = null, int? platforms = null, string? ordering = null) =>
        //{
        //    List<int> genreIds = genres?.Split(',').Select(int.Parse).ToList() ?? new List<int>();
        //    var query = db.Games.AsQueryable();

        //    if (genreIds.Count > 0)
        //    {
        //        query = query.Where(game => game.Genres.Any(genre => genreIds.Contains(genre.GenreId)));
        //    }
        //    if (platforms != null)
        //    {
        //        query = query.Where(game => game.Platforms.Any(platform => platform.PlatformId == platforms));
        //    }

        //    // Apply ordering based on the ordering parameter
        //    query = ordering?.ToLower() switch
        //    {
        //        "name" => query.OrderBy(g => g.Name),
        //        "released" => query.OrderBy(g => g.Released),
        //        "added" => query.OrderBy(g => g.Added),
        //        "created" => query.OrderBy(g => g.Created),
        //        "updated" => query.OrderBy(g => g.Update),
        //        "rating" => query.OrderBy(g => g.Rating),
        //        "metacritic" => query.OrderBy(g => g.Metacritic),
        //        _ => query // Default ordering (no specific order)
        //    };

        //    var gamesWithGenres = await query.Include(p => p.Platforms).ToListAsync();
        //    var count = await query.CountAsync();

        //    return new
        //    {
        //        Results = gamesWithGenres,
        //        Count = count
        //    };
        //})
        //.WithName("GetGamesWithCount")
        //.WithOpenApi();
        //        group.MapGet("/GetGamesWithCount", async (GamesContext db, [FromQuery] string? genres = null, int? platforms = null) =>
        //        {
        //            List<int> genreIds = genres?.Split(',').Select(int.Parse).ToList() ?? new List<int>();            

        //            var query = db.Games.AsQueryable();
        //            if (genreIds.Count > 0)
        //            {
        //                query = query.Where(game => game.Genres.Any(genre => genreIds.Contains(genre.GenreId)));
        //            }
        //            if (platforms != null)
        //            {
        //                query = query.Where(game => game.Platforms.Any(platform => platform.PlatformId == platforms));
        //            }
        //            var gamesWithGenres = await query.Include(p => p.Platforms).ToListAsync();
        //            var count = await query.CountAsync();
        //            return new
        //            {
        //                Results = gamesWithGenres,
        //                Count = count
        //            };
        //        })
        //.WithName("GetGamesWithCount")
        //.WithOpenApi();
        #endregion

        group.MapGet("/{id}", async Task<Results<Ok<Game>, NotFound>> (int gameid, GamesContext db) =>
        {
            return await db.Games.AsNoTracking()
                .FirstOrDefaultAsync(model => model.GameId == gameid)
                is Game model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetGameById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int gameid, Game game, GamesContext db) =>
        {
            var affected = await db.Games
                .Where(model => model.GameId == gameid)
                .ExecuteUpdateAsync(setters => setters
                    //.SetProperty(m => m.GameId, game.GameId)
                    .SetProperty(m => m.Name, game.Name)
                    .SetProperty(m => m.Uri, game.Uri)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateGame")
        .WithOpenApi();

        group.MapPost("/", async (Game game, GamesContext db) =>
        {
            db.Games.Add(game);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Game/{game.GameId}",game);
        })
        .WithName("CreateGame")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int gameid, GamesContext db) =>
        {
            var affected = await db.Games
                .Where(model => model.GameId == gameid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteGame")
        .WithOpenApi();
    }
}
