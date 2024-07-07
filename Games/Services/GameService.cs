using GameData;
using GameDomain;
using Microsoft.EntityFrameworkCore;

namespace Games;
public class GameService
{
    private readonly GamesContext _db;

    public GameService(GamesContext db)
    {
        _db = db;
    }

    public async Task<(List<Game> Results, int Count)> GetGamesWithCount(string? genres, int? platforms, string? ordering, string? search)
    {
        List<int> genreIds = genres?.Split(',').Select(int.Parse).ToList() ?? new List<int>();
        var query = _db.Games.AsQueryable();

        if (genreIds.Count > 0)
        {
            query = query.Where(game => game.Genres.Any(genre => genreIds.Contains(genre.GenreId)));
        }
        if (platforms != null)
        {
            query = query.Where(game => game.Platforms.Any(platform => platform.PlatformId == platforms));
        }
        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(game => EF.Functions.Like(game.Name, $"%{search}%"));
        }

        query = ApplyOrdering(query, ordering);

        var results = await query.Include(p => p.Platforms).ToListAsync();
        var count = await query.CountAsync();

        return (results, count);
    }

    private IQueryable<Game> ApplyOrdering(IQueryable<Game> query, string? ordering)
    {
        if (string.IsNullOrWhiteSpace(ordering))
            return query;

        bool isDescending = ordering.StartsWith("-");
        string orderingField = isDescending ? ordering.Substring(1) : ordering;

        return orderingField.ToLower() switch
        {
            "name" => isDescending ? query.OrderByDescending(g => g.Name) : query.OrderBy(g => g.Name),
            "released" => isDescending ? query.OrderByDescending(g => g.Released) : query.OrderBy(g => g.Released),
            "added" => isDescending ? query.OrderByDescending(g => g.Added) : query.OrderBy(g => g.Added),
            "created" => isDescending ? query.OrderByDescending(g => g.Created) : query.OrderBy(g => g.Created),
            "updated" => isDescending ? query.OrderByDescending(g => g.Update) : query.OrderBy(g => g.Update),
            "rating" => isDescending ? query.OrderByDescending(g => g.Rating) : query.OrderBy(g => g.Rating),
            "metacritic" => isDescending ? query.OrderByDescending(g => g.Metacritic) : query.OrderBy(g => g.Metacritic),
            _ => query // Default ordering (no specific order)
        };
    }
}