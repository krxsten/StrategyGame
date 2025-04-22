using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class Map
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? SizeX { get; set; }

    public int? SizeY { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<PlayerLocation> PlayerLocations { get; set; } = new List<PlayerLocation>();
}
