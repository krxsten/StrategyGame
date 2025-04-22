using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class PlayerUnit
{
    public int Id { get; set; }

    public int? PlayerId { get; set; }

    public int? UnitId { get; set; }

    public int? Quantity { get; set; }

    public virtual Player? Player { get; set; }

    public virtual Unit? Unit { get; set; }
}
