using Microsoft.EntityFrameworkCore;
using GameData;
using GameDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
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

        group.MapGet("/GetGamesWithCount", async (GamesContext db) =>
        {
            return new 
            {
                GameList = await db.Games.Include(p => p.Platforms).ToListAsync(),
                Count = await db.Games.CountAsync()
            };
        })
        .WithName("GetGamesWithCount")
        .WithOpenApi();

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
