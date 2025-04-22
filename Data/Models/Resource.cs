using System;
using System.Collections.Generic;

namespace strategy_game.Data.Models;

public partial class Resource
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<PlayerResource> PlayerResources { get; set; } = new List<PlayerResource>();
}
