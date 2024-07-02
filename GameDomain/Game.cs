using System.ComponentModel.DataAnnotations;

namespace GameDomain;

public class Game
{
    public int GameId { get; set; }
    public string? Name { get; set; }
    public string Uri { get; set; }
    public List<Platform> Platforms { get; set; } = new();
}