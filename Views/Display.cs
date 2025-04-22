using strategy_game.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_game.Views
{
    public class Display
    {
        public void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Заявки: ");
            Console.WriteLine("1. Извежда всички играчи с техните ресурси.");
            Console.WriteLine("2. Показва резултат от последните 5 битки.");
            Console.WriteLine("3. Извежда всички сгради и единици, достъпни за фракция \"Humans\".");
            Console.Write("Вашият избор: ");
            int number = int.Parse(Console.ReadLine());
            StrategyGameController strategyGameController = new StrategyGameController();
            while (number!=0)
            {
                switch (number)
                {
                    case 1:
                        foreach (var item in strategyGameController.AllPlayers())
                        {
                            Console.WriteLine($"{item.Id} {item.Username} {item.Email} {item.CreatedAt}");
                        }
                        break;
                    case 2:
                        int result= strategyGameController.ResultOfLast5Battles();
                        Console.WriteLine(result);
                        break;
                    case 3:
                        foreach (var item in strategyGameController.BuildingUnits())
                        {
                            Console.WriteLine($"{item.Id} {item.Name} {item.Description}");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Невалидна операния!");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Заявки: ");
                Console.WriteLine("1. Извежда всички играчи с техните ресурси.");
                Console.WriteLine("2. Показва резултат от последните 5 битки.");
                Console.WriteLine("3. Извежда всички сгради и единици, достъпни за фракция \"Humans\".");
                Console.Write("Вашият избор: ");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
