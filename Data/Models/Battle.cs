using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class Battle
{
    public int Id { get; set; }

    public int? AttackerId { get; set; }

    public int? DefenderId { get; set; }

    public DateOnly? StartedAt { get; set; }

    public DateOnly? EndedAt { get; set; }

    public virtual Player? Attacker { get; set; }

    public virtual ICollection<BattleUnit> BattleUnits { get; set; } = new List<BattleUnit>();

    public virtual Player? Defender { get; set; }
}
