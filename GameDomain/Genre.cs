using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDomain;

public class Genre
{
    public int GenreId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string slug { get; set; } = default!;
    public string? ImageBackground { get; set; }
    public List<Game> Games { get; set; } = new();
}
