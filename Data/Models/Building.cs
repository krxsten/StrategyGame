using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class Building
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateOnly? BuildTime { get; set; }

    public int? FactionId { get; set; }

    public virtual Faction? Faction { get; set; }

    public virtual ICollection<PlayerBuilding> PlayerBuildings { get; set; } = new List<PlayerBuilding>();
}
