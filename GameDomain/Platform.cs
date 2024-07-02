using System.ComponentModel.DataAnnotations;

namespace GameDomain;

public class Platform
{
    public int PlatformId { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public List<Game> Games { get; set; } = new();
}