using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int firstplayerpokemons = int.Parse(Console.ReadLine());
            int secondplayerpokemons = int.Parse(Console.ReadLine());
            int maxbattles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= Math.Min(firstplayerpokemons,secondplayerpokemons); i++)
            {
                for (int j = 1; j <= Math.Max(firstplayerpokemons,secondplayerpokemons); j++)
                {
                    counter++;
                    if (counter<=maxbattles)
                    {
                        Console.Write("({0} <-> {1}) ",i,j);
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
