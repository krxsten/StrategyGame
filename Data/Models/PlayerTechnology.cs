using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class PlayerTechnology
{
    public int Id { get; set; }

    public int? PlayerId { get; set; }

    public int? TechnologyId { get; set; }

    public string? IsResearched { get; set; }

    public DateOnly? ResearchedAt { get; set; }

    public virtual Player? Player { get; set; }

    public virtual Technology? Technology { get; set; }
}
