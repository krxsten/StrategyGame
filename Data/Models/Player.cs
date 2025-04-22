using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class Player
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public virtual ICollection<Battle> BattleAttackers { get; set; } = new List<Battle>();

    public virtual ICollection<Battle> BattleDefenders { get; set; } = new List<Battle>();

    public virtual ICollection<BattleUnit> BattleUnits { get; set; } = new List<BattleUnit>();

    public virtual ICollection<PlayerBuilding> PlayerBuildings { get; set; } = new List<PlayerBuilding>();

    public virtual ICollection<PlayerFaction> PlayerFactions { get; set; } = new List<PlayerFaction>();

    public virtual ICollection<PlayerLocation> PlayerLocations { get; set; } = new List<PlayerLocation>();

    public virtual ICollection<PlayerResource> PlayerResources { get; set; } = new List<PlayerResource>();

    public virtual ICollection<PlayerTechnology> PlayerTechnologies { get; set; } = new List<PlayerTechnology>();

    public virtual ICollection<PlayerUnit> PlayerUnits { get; set; } = new List<PlayerUnit>();
}
