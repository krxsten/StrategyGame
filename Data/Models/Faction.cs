using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class Faction
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Building> Buildings { get; set; } = new List<Building>();

    public virtual ICollection<PlayerFaction> PlayerFactions { get; set; } = new List<PlayerFaction>();

    public virtual ICollection<Unit> Units { get; set; } = new List<Unit>();
}
