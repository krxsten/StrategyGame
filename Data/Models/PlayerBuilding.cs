using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class PlayerBuilding
{
    public int Id { get; set; }

    public int? PlayerId { get; set; }

    public int? BuildingId { get; set; }

    public int? Level { get; set; }

    public DateOnly? BuiltAt { get; set; }

    public virtual Building? Building { get; set; }

    public virtual Player? Player { get; set; }
}
