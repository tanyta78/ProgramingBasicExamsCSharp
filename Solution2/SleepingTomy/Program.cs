using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingTomy
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int holydays = int.Parse(Console.ReadLine());
            int workingdays = 365 - holydays;
            
            int playingmin = holydays * 127 + workingdays * 63;
            if (playingmin<= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", (30000- playingmin) / 60, (30000 - playingmin) % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", (playingmin-30000) / 60, (playingmin-30000) % 60);
            }
        }
    }
}
