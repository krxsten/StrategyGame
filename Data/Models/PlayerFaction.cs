using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class PlayerFaction
{
    public int Id { get; set; }

    public int? PlayerId { get; set; }

    public int? FactionId { get; set; }

    public DateOnly? StartDate { get; set; }

    public virtual Faction? Faction { get; set; }

    public virtual Player? Player { get; set; }
}
