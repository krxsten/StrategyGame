using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class PlayerLocation
{
    public int Id { get; set; }

    public int? PlayerId { get; set; }

    public int? MapId { get; set; }

    public int? X { get; set; }

    public int? Y { get; set; }

    public virtual Map? Map { get; set; }

    public virtual Player? Player { get; set; }
}
