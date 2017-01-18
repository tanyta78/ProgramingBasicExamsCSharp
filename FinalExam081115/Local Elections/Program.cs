using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofCandidates = int.Parse(Console.ReadLine());
            int vote = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            string first = "...+-----+...";
            for (int n = 0; n < numberofCandidates; n++)
            {
                Console.WriteLine(new string('.', 13));
                if (n==vote-1)
                {
                    switch (symbol)
                    {
                        case "X":
                        case "x":
                            Console.WriteLine(first);
                            Console.WriteLine("...|.\\./.|...");
                            Console.WriteLine("{0:00}.|..X..|...",n+1);
                            Console.WriteLine("...|./.\\.|...");
                            Console.WriteLine(first);
                            break;
                        case "V":
                        case "v":
                            Console.WriteLine(first);
                            Console.WriteLine("...|\\.../|...");
                            Console.WriteLine("{0:00}.|.\\./.|...", n+1);
                            Console.WriteLine("...|..V..|...");
                            Console.WriteLine(first);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(first);
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("{0:00}.|.....|...", n+1);
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine(first);
                }

            }
            Console.WriteLine(new string('.', 13));
        }
    }
}
