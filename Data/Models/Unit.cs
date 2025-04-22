using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? AttackPower { get; set; }

    public int? DefensePower { get; set; }

    public DateOnly? TrainingTime { get; set; }

    public int? FactionId { get; set; }

    public virtual ICollection<BattleUnit> BattleUnits { get; set; } = new List<BattleUnit>();

    public virtual Faction? Faction { get; set; }

    public virtual ICollection<PlayerUnit> PlayerUnits { get; set; } = new List<PlayerUnit>();
}
