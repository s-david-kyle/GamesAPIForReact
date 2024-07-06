using Microsoft.EntityFrameworkCore;
using GameData;
using GameDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace Games;

public static class GenreEndpoints
{
    public static void MapGenreEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Genre").WithTags(nameof(Genre));

        group.MapGet("/", async (GamesContext db) =>
        {
            return await db.Genres.ToListAsync();
        })
        .WithName("GetAllGenres")
        .WithOpenApi();

        group.MapGet("/GetGenresWithCount", async (GamesContext db) =>
        {
            return new
            {
                Results = await db.Genres.ToListAsync(),
                Count = await db.Genres.CountAsync()
            };
        })
        .WithName("GetGenresWithCount")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Genre>, NotFound>> (int genreid, GamesContext db) =>
        {
            return await db.Genres.AsNoTracking()
                .FirstOrDefaultAsync(model => model.GenreId == genreid)
                is Genre model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetGenreById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int genreid, Genre genre, GamesContext db) =>
        {
            var affected = await db.Genres
                .Where(model => model.GenreId == genreid)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.GenreId, genre.GenreId)
                    .SetProperty(m => m.Name, genre.Name)
                    .SetProperty(m => m.Description, genre.Description)
                    .SetProperty(m => m.slug, genre.slug)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateGenre")
        .WithOpenApi();

        group.MapPost("/", async (Genre genre, GamesContext db) =>
        {
            db.Genres.Add(genre);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Genre/{genre.GenreId}",genre);
        })
        .WithName("CreateGenre")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int genreid, GamesContext db) =>
        {
            var affected = await db.Genres
                .Where(model => model.GenreId == genreid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteGenre")
        .WithOpenApi();
    }
}
