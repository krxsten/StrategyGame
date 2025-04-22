using Microsoft.EntityFrameworkCore;
using strategy_game.Data;
using strategy_game.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_game.Controller
{
    public class StrategyGameController
    {
        public StrategyGameContext context = new StrategyGameContext();
        public List<Player> AllPlayers()
        {
            return context.Players.ToList();
        }
        public int ResultOfLast5Battles()
        {
            return context.BattleUnits.OrderByDescending(b => b.Id).Take(5).Sum(x=>x.Quantity);
        }
        public List<Faction> BuildingUnits()
        {
            return context.Factions.Include(f => f.Buildings).Include(f => f.Units).Where(f => f.Name == "Humans").ToList();
        }
    }
}
