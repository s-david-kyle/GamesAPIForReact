using Microsoft.EntityFrameworkCore;
using GameData;
using GameDomain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace Games;

public static class PlatformEndpoints
{
    public static void MapPlatformEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Platforms").WithTags(nameof(Platform));

        group.MapGet("/", async (GamesContext db) =>
        {
            return await db.Platforms.ToListAsync();
        })
        .WithName("GetAllPlatforms")
        .WithOpenApi();

        group.MapGet("/lists/parents", async (GamesContext db) =>
        {
            return new
            {
                Results = await db.Platforms.ToListAsync(),
                Count = await db.Platforms.CountAsync()
            };
        })
        .WithName("GetPlatformsWithCount")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Platform>, NotFound>> (int platformid, GamesContext db) =>
        {
            return await db.Platforms.AsNoTracking()
                .FirstOrDefaultAsync(model => model.PlatformId == platformid)
                is Platform model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetPlatformById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int platformid, Platform platform, GamesContext db) =>
        {
            var affected = await db.Platforms
                .Where(model => model.PlatformId == platformid)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.PlatformId, platform.PlatformId)
                    .SetProperty(m => m.Name, platform.Name)
                    .SetProperty(m => m.Slug, platform.Slug)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdatePlatform")
        .WithOpenApi();

        group.MapPost("/", async (Platform platform, GamesContext db) =>
        {
            db.Platforms.Add(platform);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Platform/{platform.PlatformId}",platform);
        })
        .WithName("CreatePlatform")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int platformid, GamesContext db) =>
        {
            var affected = await db.Platforms
                .Where(model => model.PlatformId == platformid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeletePlatform")
        .WithOpenApi();
    }
}
