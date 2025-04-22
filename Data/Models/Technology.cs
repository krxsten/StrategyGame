using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class Technology
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateOnly? ResearchTime { get; set; }

    public virtual ICollection<PlayerTechnology> PlayerTechnologies { get; set; } = new List<PlayerTechnology>();
}
