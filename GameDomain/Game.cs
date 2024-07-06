using System.ComponentModel.DataAnnotations;

namespace GameDomain;

public class Game
{
    public int GameId { get; set; }
    public string? Name { get; set; }
    public string Uri { get; set; }
    public List<Platform> Platforms { get; set; } = new();
    public List<Genre> Genres { get; set; } = new();
    public int? Metacritic { get; set; }
    public DateOnly Released { get; set; }
    public DateOnly Added { get; set; }
    public DateOnly Created { get; set; }
    public DateOnly Update { get; set; }
    public string? Rating { get; set; }
}