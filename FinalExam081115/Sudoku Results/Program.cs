using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesplayed = 0;
            int totalsec = 0;
            string comand = Console.ReadLine();
            while (comand != "Quit")
            {
                gamesplayed++;
                int gamesmin = int.Parse(comand.Substring(0, 2));
                int gamessec = int.Parse(comand.Substring(3, 2));
                totalsec = 60*gamesmin+totalsec+gamessec;
                comand= Console.ReadLine();
            }
            double averigesec = (double)totalsec / gamesplayed;
            
            if (averigesec<720)
            {
                Console.WriteLine("Gold Star");
            }
            else
            {
                if (averigesec<=1440)
                {
                    Console.WriteLine("Silver Star");
                }
                else
                {
                    Console.WriteLine("Bronze Star");
                }
            }
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", gamesplayed,Math.Ceiling(averigesec));
        }
    }
}
